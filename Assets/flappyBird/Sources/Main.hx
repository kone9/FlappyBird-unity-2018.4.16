// Auto-generated
package ;
class Main {
    public static inline var projectName = 'flappyBird babylon';
    public static inline var projectPackage = 'arm';
    public static function main() {
        iron.object.BoneAnimation.skinMaxBones = 8;
        armory.system.Starter.numAssets = 49;
        armory.system.Starter.drawLoading = armory.trait.internal.LoadingScreen.render;
        armory.system.Starter.main(
            'EscenaPrincipal',
            0,
            false,
            true,
            false,
            640,
            480,
            1,
            true,
            armory.renderpath.RenderPathCreator.get
        );
    }
}
