# Project Name

Project description, purposes, etc.

## Requirements

- **Unity:** [2020.3.15f1](https://unity3d.com/ru/get-unity/download/archive)
- **Platforms:**
  - Android
  - iOS

## Packages

- [Zenject](https://github.com/modesttree/Zenject) - for dependency management
- [TextMesh Pro](https://docs.unity3d.com/Manual/com.unity.textmeshpro.html) - for text components (instead of `UnityEngine.UI.Text`)
- [Evolunity](https://github.com/Bodix/Evolunity) - for speed up development (extensions and utilities)
- [Lunar Console](https://github.com/SpaceMadness/lunar-unity-console) - for console on mobile devices

## Possible packages (not installed)

Packages that can be installed into the project to solve common problems.

- [ARFoundation](https://docs.unity3d.com/Packages/com.unity.xr.arfoundation@3.0/manual/index.html) (3.0.1) - for AR
  - [ARCore](https://docs.unity3d.com/Packages/com.unity.xr.arcore@3.0/manual/index.html) (3.0.4) - for supporting AR on Android
  - [ARKit](https://docs.unity3d.com/Packages/com.unity.xr.arkit@3.0/manual/) (3.0.4) - for supporting AR on iOS
- [Unity UI Extensions](https://bitbucket.org/UnityUIExtensions/unity-ui-extensions/wiki/Home) - for advanced UI elements
- [Modern UI Pack](https://assetstore.unity.com/packages/tools/gui/modern-ui-pack-150824) - for advanced UI elements
- [Lean Touch](https://assetstore.unity.com/packages/tools/input-management/lean-touch-30111) - for gestures handling
- [Lean Pool](https://assetstore.unity.com/packages/tools/utilities/lean-pool-35666) - for object pooling
- [DOTween](http://dotween.demigiant.com/) - for animations from code
- [Quick Outline](https://assetstore.unity.com/packages/tools/particles-effects/quick-outline-115488) - for outlining selected AR effects
- [NatCorder](https://assetstore.unity.com/packages/tools/integration/natcorder-video-recording-api-102645) - for video recording in runtime
- [Ultimate LOD System MT](https://assetstore.unity.com/packages/tools/utilities/ultimate-lod-system-mt-170425) - for LOD system
- [Safe Area Helper](https://assetstore.unity.com/packages/tools/gui/safe-area-helper-130488) - for convenient handling different safe areas
- [Unity Native Share](https://github.com/yasirkula/UnityNativeShare) - for sharing feature
- [GLTFUtility](https://github.com/Siccity/GLTFUtility) - for GLTF/GLB support
- [UniWebView 4](https://uniwebview.com/) - for playing YouTube video
- [YouTube Data API v3](https://developers.google.com/api-client-library/dotnet/apis/youtube/v3?hl=ru) - for retrieving data from YouTube
- [UniTask](https://github.com/Cysharp/UniTask) - for async operations
- [NuGetForUnity](https://github.com/GlitchEnzo/NuGetForUnity) - for using NuGet packages

## References

- [Google Drive](https://drive.google.com)
- [Jira](https://www.atlassian.com/ru/software/jira)

## Using

1. Clone repository.
2. Rename project folder.
3. Update `README.md`.
   - Update name.
   - Update description.
   - Update Unity version (if needed).
   - Update platforms (if needed)
   - Update packages.
   - Remove **Possible packages** section.
   - Update references.
   - Remove **Using** section.
4. Update **Project Settings** in Unity.
   - **Player** tab:
     - Update **Company Name** (if needed).
     - Update **Product Name**.
     - Update **Package Name** (lowercase).
       - `com.companyname.productname`
   - **Editor** tab:
     - Update **Root namespace**.
5. Update namespace in the scripts (according to the **Root namespace**).
6. Recreate git repository.
   - Remove `.git` folder (may be invisible).
   - Initialize new repository.
     - `git init`
   - Add new remote.
     - `git remote add origin <URL>`
   - Create new commit.
     - `git add -A`
     - `git commit -m "Add project files"`
   - Push **master** branch to remote.
     - `git push --set-upstream origin master`
   - Create and checkout `develop` branch.
     - `git checkout -b develop`
   - Push **develop** branch to remote.
     - `git push --set-upstream origin develop`
