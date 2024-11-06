using UnityEditor;
using UnityEngine;

public static class GameBuilder
{
    public static void BuildPC()
    {
        // ������ ������� ������
        BuildPipeline.BuildPlayer(
            new string[] { "Assets/Scenes/MainScene.unity" }, // ���� � ������
            "Builds/PC/Project.exe", // ���� ��� ���������� ������
            BuildTarget.StandaloneWindows64, // ��������� ������
            BuildOptions.None
        );
    }
}