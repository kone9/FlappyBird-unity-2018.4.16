// Auto-generated
let project = new Project('flappyBird babylon');

project.addSources('Sources');
project.addLibrary("../../../../programas instalados/armory engine Blender 2.8/ArmorySDK/armory");
project.addLibrary("../../../../programas instalados/armory engine Blender 2.8/ArmorySDK/iron");
project.addParameter('-dce full');
project.addShaders("build_flappyBird babylon/compiled/Shaders/*.glsl", { noembed: false});
project.addAssets("build_flappyBird babylon/compiled/Assets/**", { notinlist: true });
project.addAssets("build_flappyBird babylon/compiled/Shaders/*.arm", { notinlist: true });
project.addAssets("amarillo.jpg", { notinlist: true });
project.addAssets("blanco.jpg", { notinlist: true });
project.addAssets("rojo.jpg", { notinlist: true });
project.addAssets("verde.jpg", { notinlist: true });
project.addDefine('arm_legacy');
project.addDefine('rp_renderer=Forward');
project.addDefine('rp_shadowmap');
project.addDefine('rp_shadowmap_cascade=1024');
project.addDefine('rp_shadowmap_cube=256');
project.addDefine('rp_background=Clear');
project.addDefine('arm_audio');
project.addDefine('arm_published');
project.addDefine('arm_soundcompress');
project.addDefine('arm_skin');
project.addDefine('arm_particles');
project.addDefine('arm_loadscreen');
project.addDefine('arm_resizable');


resolve(project);
