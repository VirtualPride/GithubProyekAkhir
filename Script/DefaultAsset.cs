#region Assembly UnityEditor.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// location unknown
// Decompiled with ICSharpCode.Decompiler 8.1.1.7464
#endregion

using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Bindings;

// namespace UnityEditor;

//
// Summary:
//     DefaultAsset is used for assets that do not have a specific type (yet).
// [NativeHeader("Modules/AssetPipelineEditor/Public/DefaultImporter.h")]
public class DefaultAsset : Object
{
    internal extern string message
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        get;
    }

    internal extern bool isWarning
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        // [NativeName("IsWarning")]
        get;
    }

    private DefaultAsset()
    {
    }
}
#if false // Decompilation log
'310' items in cache
------------------
Resolve: 'mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
Found single assembly: 'mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
Load from: 'C:\Studio\Unity Version Archive\2021.3.16f1\Editor\Data\NetStandard\compat\2.1.0\shims\netfx\mscorlib.dll'
------------------
Resolve: 'UnityEngine.SharedInternalsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null'
Found single assembly: 'UnityEngine.SharedInternalsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null'
Load from: 'C:\Studio\Unity Version Archive\2021.3.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.SharedInternalsModule.dll'
------------------
Resolve: 'UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null'
Found single assembly: 'UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null'
Load from: 'C:\Studio\Unity Version Archive\2021.3.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll'
------------------
Resolve: 'UnityEngine.IMGUIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null'
Found single assembly: 'UnityEngine.IMGUIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null'
Load from: 'C:\Studio\Unity Version Archive\2021.3.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.IMGUIModule.dll'
------------------
Resolve: 'System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
Found single assembly: 'System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
Load from: 'C:\Studio\Unity Version Archive\2021.3.16f1\Editor\Data\NetStandard\compat\2.1.0\shims\netfx\System.dll'
------------------
Resolve: 'UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null'
Found single assembly: 'UnityEngine.UIElementsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null'
Load from: 'C:\Studio\Unity Version Archive\2021.3.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIElementsModule.dll'
------------------
Resolve: 'UnityEngine.TerrainModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null'
Found single assembly: 'UnityEngine.TerrainModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null'
Load from: 'C:\Studio\Unity Version Archive\2021.3.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.TerrainModule.dll'
------------------
Resolve: 'System.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
Found single assembly: 'System.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
Load from: 'C:\Studio\Unity Version Archive\2021.3.16f1\Editor\Data\NetStandard\compat\2.1.0\shims\netfx\System.Core.dll'
------------------
Resolve: 'UnityEngine.PhysicsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null'
Found single assembly: 'UnityEngine.PhysicsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null'
Load from: 'C:\Studio\Unity Version Archive\2021.3.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.PhysicsModule.dll'
------------------
Resolve: 'System.Runtime.Serialization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
Found single assembly: 'System.Runtime.Serialization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
Load from: 'C:\Studio\Unity Version Archive\2021.3.16f1\Editor\Data\NetStandard\compat\2.1.0\shims\netfx\System.Runtime.Serialization.dll'
------------------
Resolve: 'UnityEngine.UnityAnalyticsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null'
Found single assembly: 'UnityEngine.UnityAnalyticsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null'
Load from: 'C:\Studio\Unity Version Archive\2021.3.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.UnityAnalyticsModule.dll'
------------------
Resolve: 'UnityEngine.AnimationModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null'
Found single assembly: 'UnityEngine.AnimationModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null'
Load from: 'C:\Studio\Unity Version Archive\2021.3.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.AnimationModule.dll'
------------------
Resolve: 'UnityEngine.TilemapModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null'
Found single assembly: 'UnityEngine.TilemapModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null'
Load from: 'C:\Studio\Unity Version Archive\2021.3.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.TilemapModule.dll'
------------------
Resolve: 'UnityEngine.ParticleSystemModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null'
Found single assembly: 'UnityEngine.ParticleSystemModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null'
Load from: 'C:\Studio\Unity Version Archive\2021.3.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.ParticleSystemModule.dll'
------------------
Resolve: 'UnityEngine.TextRenderingModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null'
Found single assembly: 'UnityEngine.TextRenderingModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null'
Load from: 'C:\Studio\Unity Version Archive\2021.3.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.TextRenderingModule.dll'
------------------
Resolve: 'Unity.Cecil, Version=0.10.0.0, Culture=neutral, PublicKeyToken=fc15b93552389f74'
Could not find by name: 'Unity.Cecil, Version=0.10.0.0, Culture=neutral, PublicKeyToken=fc15b93552389f74'
------------------
Resolve: 'UnityEngine.VideoModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null'
Found single assembly: 'UnityEngine.VideoModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null'
Load from: 'C:\Studio\Unity Version Archive\2021.3.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.VideoModule.dll'
------------------
Resolve: 'UnityEngine.AudioModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null'
Found single assembly: 'UnityEngine.AudioModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null'
Load from: 'C:\Studio\Unity Version Archive\2021.3.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.AudioModule.dll'
------------------
Resolve: 'UnityEngine.AssetBundleModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null'
Found single assembly: 'UnityEngine.AssetBundleModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null'
Load from: 'C:\Studio\Unity Version Archive\2021.3.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.AssetBundleModule.dll'
------------------
Resolve: 'UnityEngine.InputLegacyModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null'
Found single assembly: 'UnityEngine.InputLegacyModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null'
Load from: 'C:\Studio\Unity Version Archive\2021.3.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.InputLegacyModule.dll'
------------------
Resolve: 'UnityEngine.Physics2DModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null'
Found single assembly: 'UnityEngine.Physics2DModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null'
Load from: 'C:\Studio\Unity Version Archive\2021.3.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.Physics2DModule.dll'
------------------
Resolve: 'System.Xml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
Found single assembly: 'System.Xml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
Load from: 'C:\Studio\Unity Version Archive\2021.3.16f1\Editor\Data\NetStandard\compat\2.1.0\shims\netfx\System.Xml.dll'
------------------
Resolve: 'UnityEngine.XRModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null'
Found single assembly: 'UnityEngine.XRModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null'
Load from: 'C:\Studio\Unity Version Archive\2021.3.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.XRModule.dll'
------------------
Resolve: 'UnityEngine.VRModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null'
Found single assembly: 'UnityEngine.VRModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null'
Load from: 'C:\Studio\Unity Version Archive\2021.3.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.VRModule.dll'
------------------
Resolve: 'UnityEngine.UIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null'
Found single assembly: 'UnityEngine.UIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null'
Load from: 'C:\Studio\Unity Version Archive\2021.3.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.UIModule.dll'
------------------
Resolve: 'UnityEngine.ClothModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null'
Found single assembly: 'UnityEngine.ClothModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null'
Load from: 'C:\Studio\Unity Version Archive\2021.3.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.ClothModule.dll'
------------------
Resolve: 'UnityEngine.DirectorModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null'
Found single assembly: 'UnityEngine.DirectorModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null'
Load from: 'C:\Studio\Unity Version Archive\2021.3.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.DirectorModule.dll'
------------------
Resolve: 'UnityEngine.VirtualTexturingModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null'
Found single assembly: 'UnityEngine.VirtualTexturingModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null'
Load from: 'C:\Studio\Unity Version Archive\2021.3.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.VirtualTexturingModule.dll'
------------------
Resolve: 'UnityEngine.AIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null'
Found single assembly: 'UnityEngine.AIModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null'
Load from: 'C:\Studio\Unity Version Archive\2021.3.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.AIModule.dll'
------------------
Resolve: 'UnityEngine.StreamingModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null'
Found single assembly: 'UnityEngine.StreamingModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null'
Load from: 'C:\Studio\Unity Version Archive\2021.3.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.StreamingModule.dll'
------------------
Resolve: 'UnityEngine.WindModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null'
Found single assembly: 'UnityEngine.WindModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null'
Load from: 'C:\Studio\Unity Version Archive\2021.3.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.WindModule.dll'
------------------
Resolve: 'UnityEngine.GridModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null'
Found single assembly: 'UnityEngine.GridModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null'
Load from: 'C:\Studio\Unity Version Archive\2021.3.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.GridModule.dll'
------------------
Resolve: 'UnityEngine.TerrainPhysicsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null'
Found single assembly: 'UnityEngine.TerrainPhysicsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null'
Load from: 'C:\Studio\Unity Version Archive\2021.3.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.TerrainPhysicsModule.dll'
------------------
Resolve: 'UnityEngine.VehiclesModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null'
Found single assembly: 'UnityEngine.VehiclesModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null'
Load from: 'C:\Studio\Unity Version Archive\2021.3.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.VehiclesModule.dll'
------------------
Resolve: 'UnityEngine.SpriteMaskModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null'
Found single assembly: 'UnityEngine.SpriteMaskModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null'
Load from: 'C:\Studio\Unity Version Archive\2021.3.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.SpriteMaskModule.dll'
------------------
Resolve: 'UnityEngine.SubsystemsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null'
Found single assembly: 'UnityEngine.SubsystemsModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null'
Load from: 'C:\Studio\Unity Version Archive\2021.3.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.SubsystemsModule.dll'
------------------
Resolve: 'UnityEngine.VFXModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null'
Found single assembly: 'UnityEngine.VFXModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null'
Load from: 'C:\Studio\Unity Version Archive\2021.3.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.VFXModule.dll'
------------------
Resolve: 'Bee.BeeDriver, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'
Could not find by name: 'Bee.BeeDriver, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'
------------------
Resolve: 'PlayerBuildProgramLibrary.Data, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null'
Could not find by name: 'PlayerBuildProgramLibrary.Data, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null'
------------------
Resolve: 'UnityEngine.SpriteShapeModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null'
Found single assembly: 'UnityEngine.SpriteShapeModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null'
Load from: 'C:\Studio\Unity Version Archive\2021.3.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.SpriteShapeModule.dll'
------------------
Resolve: 'Unity.CompilationPipeline.Common, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null'
Could not find by name: 'Unity.CompilationPipeline.Common, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null'
------------------
Resolve: 'System.Xml.Linq, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
Found single assembly: 'System.Xml.Linq, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
Load from: 'C:\Studio\Unity Version Archive\2021.3.16f1\Editor\Data\NetStandard\compat\2.1.0\shims\netfx\System.Xml.Linq.dll'
------------------
Resolve: 'ScriptCompilationBuildProgram.Data, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null'
Could not find by name: 'ScriptCompilationBuildProgram.Data, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null'
------------------
Resolve: 'BeeBuildProgramCommon.Data, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null'
Could not find by name: 'BeeBuildProgramCommon.Data, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null'
------------------
Resolve: 'UnityEngine.ImageConversionModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null'
Found single assembly: 'UnityEngine.ImageConversionModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null'
Load from: 'C:\Studio\Unity Version Archive\2021.3.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.ImageConversionModule.dll'
------------------
Resolve: 'UnityEngine.UnityConnectModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null'
Found single assembly: 'UnityEngine.UnityConnectModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null'
Load from: 'C:\Studio\Unity Version Archive\2021.3.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.UnityConnectModule.dll'
------------------
Resolve: 'UnityEngine.PerformanceReportingModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null'
Found single assembly: 'UnityEngine.PerformanceReportingModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null'
Load from: 'C:\Studio\Unity Version Archive\2021.3.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.PerformanceReportingModule.dll'
------------------
Resolve: 'UnityEngine.JSONSerializeModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null'
Found single assembly: 'UnityEngine.JSONSerializeModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null'
Load from: 'C:\Studio\Unity Version Archive\2021.3.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.JSONSerializeModule.dll'
------------------
Resolve: 'UnityEngine.AccessibilityModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null'
Found single assembly: 'UnityEngine.AccessibilityModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null'
Load from: 'C:\Studio\Unity Version Archive\2021.3.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.AccessibilityModule.dll'
------------------
Resolve: 'UnityEngine.UnityWebRequestModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null'
Found single assembly: 'UnityEngine.UnityWebRequestModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null'
Load from: 'C:\Studio\Unity Version Archive\2021.3.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.UnityWebRequestModule.dll'
------------------
Resolve: 'UnityEngine.ScreenCaptureModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null'
Found single assembly: 'UnityEngine.ScreenCaptureModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null'
Load from: 'C:\Studio\Unity Version Archive\2021.3.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.ScreenCaptureModule.dll'
------------------
Resolve: 'UnityEngine.UNETModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null'
Found single assembly: 'UnityEngine.UNETModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null'
Load from: 'C:\Studio\Unity Version Archive\2021.3.16f1\Editor\Data\Managed\UnityEngine\UnityEngine.UNETModule.dll'
------------------
Resolve: 'Microsoft.Win32.Registry, Version=4.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Could not find by name: 'Microsoft.Win32.Registry, Version=4.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
------------------
Resolve: 'netstandard, Version=2.1.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
Found single assembly: 'netstandard, Version=2.1.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
Load from: 'C:\Studio\Unity Version Archive\2021.3.16f1\Editor\Data\NetStandard\ref\2.1.0\netstandard.dll'
------------------
Resolve: 'System.Security.Principal.Windows, Version=4.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Could not find by name: 'System.Security.Principal.Windows, Version=4.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
------------------
Resolve: 'System.Security.AccessControl, Version=4.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
Could not find by name: 'System.Security.AccessControl, Version=4.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
------------------
Resolve: 'System.CodeDom, Version=4.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
Could not find by name: 'System.CodeDom, Version=4.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
#endif
