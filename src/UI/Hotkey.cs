using System;
using System.Collections.Generic;
namespace linerider.UI
{
    public enum Hotkey
    {
        None,

        ToggleAll,

        EditorPencilTool,
        EditorLineTool,
        EditorEraserTool,
        EditorSelectTool,
        EditorPanTool,
        EditorQuickPan,
        EditorDragCanvas,

        SceneryIncreaseBig,
        SceneryDecreaseBig,
        ScenerySetSmall,

        AccelerationSetSmall,
        AccelerationSetMedium,
        AccelerationSetLarge,
        AccelerationSetMax,

        EditorToolColor1,
        EditorToolColor2,
        EditorToolColor3,
        EditorRemoveLatestLine,
        EditorFocusStart,
        EditorFocusLastLine,
        EditorCycleToolSetting,
        EditorUndo,
        EditorRedo,
        EditorFocusRider,
        EditorFocusFlag,
        EditorCancelTool,
        EditorMoveStart,

        ToolLifeLock,
        ToolAngleLock,
        ToolAxisLock,
        ToolPerpendicularAxisLock,
        ToolLengthLock,
        ToolXYSnap,
        ToolToggleSnap,
        ToolSelectBothJoints,
        ToolToggleOverlay,
        ToolCopy,
        ToolCut,
        ToolPaste,
        ToolDelete,
        ToolAddSelection,
        ToolToggleSelection,
        ToolScaleAspectRatio,
        LineToolFlipLine,

        PlaybackStartSlowmo,
        PlaybackStartIgnoreFlag,
        PlaybackStartGhostFlag,
        PlaybackStart,
        PlaybackStop,
        PlaybackFlag,
        PlaybackSlowmo,
        PlaybackZoom,
        PlaybackUnzoom,
        PlaybackSpeedUp,
        PlaybackSpeedDown,
        PlaybackFrameNext,
        PlaybackFramePrev,
        PlaybackIterationNext,
        PlaybackIterationPrev,
        PlaybackTogglePause,
        PlaybackForward,
        PlaybackBackward,
        PlaybackResetCamera,
        PreferenceOnionSkinning,
        PreferencesWindow,
        GameMenuWindow,
        TrackPropertiesWindow,
        LoadWindow,
        Quicksave,

        PlayButtonIgnoreFlag
    }

}