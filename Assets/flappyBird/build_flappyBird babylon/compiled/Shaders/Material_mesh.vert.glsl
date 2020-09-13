#version 450
in vec4 pos;
in vec2 nor;
in vec2 tex;
out vec2 texCoord;
out vec3 wnormal;
out vec4 lightPosition;
out vec3 wposition;
uniform mat3 N;
uniform mat4 WVP;
uniform float texUnpack;
uniform mat4 LWVP;
uniform mat4 W;
void main() {
vec4 spos = vec4(pos.xyz, 1.0);
wposition = vec4(W * spos).xyz;
	wnormal = normalize(N * vec3(nor.xy, pos.w));
	gl_Position = WVP * spos;
	texCoord = tex * texUnpack;
	lightPosition = LWVP * spos;
}
