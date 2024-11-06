using UnityEditor;
using UnityEngine;

public static class GameBuilder
{
    public static void BuildPC()
    {
        // Пример команды сборки
        BuildPipeline.BuildPlayer(
            new string[] { "Assets/Scenes/MainScene.unity" }, // Путь к сценам
            "Builds/PC/Project.exe", // Путь для сохранения сборки
            BuildTarget.StandaloneWindows64, // Платформа сборки
            BuildOptions.None
        );
    }
}