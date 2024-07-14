
Shader "Custom/Translucent"
{
   Properties {
		_Color ("Color Tint", Color) = (1, 1, 1, 1)
		_MainTex ("Main Tex", 2D) = "white" {}
		//����ʹ��һ���µ�����_AlphaScale �����ԭ�ȵ�_Cutoff ���ԡ�_AlphaScale������͸�������Ļ����Ͽ��������͸���ȡ�
		_AlphaScale ("Alpha_Scale", Range(0, 1)) = 1
	}
	SubShader {
		//��Queue��ǩ����ΪAlphaparent	
		//��IgnoreProjector����Ϊtrue����ζ�����Shader�����ܵ�ͶӰ��(Properties)��Ӱ��
		//RenderType��ǩ������Unity�����Shader���뵽��ǰ�������(�������Transparent��)����ָ����Shader��һ��ʹ����͸���Ȼ�ϵ�Shader
		//ʹ����͸���Ȳ��Ե�Shader��Ӧ����SubShader������������ǩ
		Tags {"Queue"="Transparent" "IgnoreProjector"="True" "RenderType"="Transparent"}
		
		Pass {
			ZWrite On
			ColorMask 0
		}

		Pass {
			Tags { "LightMode"="ForwardBase" }
			//Ϊ͸���Ȼ�Ͻ��к��ʵĻ��״̬����
			//�ر����д��
			ZWrite Off
			//ʹ����Blend SrcFactor DstFactor����
			//��Դ��ɫ(��ƬԪ��ɫ����������ɫ)�Ļ������SrcFactor��ΪSrcAlpha, ��Ŀ����ɫ(�Ѿ���������ɫ�����е���ɫ)�Ļ������ DstFactor��Ϊ OneMinusSrcAlpha ��
			Blend SrcAlpha OneMinusSrcAlpha//�ⲿ�������� �� �ὲ��
			
			CGPROGRAM
			
			#pragma vertex vert
			#pragma fragment frag
			
			#include "Lighting.cginc"
			
			fixed4 _Color;
			sampler2D _MainTex;
			float4 _MainTex_ST;
			fixed _AlphaScale;
			
			struct a2v {
				float4 vertex : POSITION;
				float3 normal : NORMAL;
				float4 texcoord : TEXCOORD0;
			};
			
			struct v2f {
				float4 pos : SV_POSITION;
				float3 worldNormal : TEXCOORD0;
				float3 worldPos : TEXCOORD1;
				float2 uv : TEXCOORD2;
			};
			
			v2f vert(a2v v) {
				v2f o;
				o.pos = UnityObjectToClipPos(v.vertex);
				
				o.worldNormal = UnityObjectToWorldNormal(v.normal);
				
				o.worldPos = mul(unity_ObjectToWorld, v.vertex).xyz;
				
				o.uv = TRANSFORM_TEX(v.texcoord, _MainTex);
				
				return o;
			}
			
			fixed4 frag(v2f i) : SV_Target {
				fixed3 worldNormal = normalize(i.worldNormal);
				fixed3 worldLightDir = normalize(UnityWorldSpaceLightDir(i.worldPos));
				
				fixed4 texColor = tex2D(_MainTex, i.uv);
				
				fixed3 albedo = texColor.rgb * _Color.rgb;
				
				fixed3 ambient = UNITY_LIGHTMODEL_AMBIENT.xyz * albedo;
				
				fixed3 diffuse = _LightColor0.rgb * albedo * max(0, dot(worldNormal, worldLightDir));
				
				//�����˸�ƬԪ��ɫ������ֵ�е�͸��ͨ���������������ص�͸��ͨ���Ͳ��ʲ���_AlphaScale�ĳ˻���
				return fixed4(ambient + diffuse, texColor.a * _AlphaScale);
			}
			
			ENDCG
		}
	} 
	FallBack "Transparent/VertexLit"
}
