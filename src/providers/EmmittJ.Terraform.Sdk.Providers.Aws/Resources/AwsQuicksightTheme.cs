using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for configuration in AwsQuicksightTheme.
/// Nesting mode: list
/// </summary>
public class AwsQuicksightThemeConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "configuration";

    /// <summary>
    /// DataColorPalette block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataColorPalette block(s) allowed")]
    public TerraformList<AwsQuicksightThemeConfigurationBlockDataColorPaletteBlock>? DataColorPalette
    {
        get => GetArgument<TerraformList<AwsQuicksightThemeConfigurationBlockDataColorPaletteBlock>>("data_color_palette");
        set => SetArgument("data_color_palette", value);
    }

    /// <summary>
    /// Sheet block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Sheet block(s) allowed")]
    public TerraformList<AwsQuicksightThemeConfigurationBlockSheetBlock>? Sheet
    {
        get => GetArgument<TerraformList<AwsQuicksightThemeConfigurationBlockSheetBlock>>("sheet");
        set => SetArgument("sheet", value);
    }

    /// <summary>
    /// Typography block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Typography block(s) allowed")]
    public TerraformList<AwsQuicksightThemeConfigurationBlockTypographyBlock>? Typography
    {
        get => GetArgument<TerraformList<AwsQuicksightThemeConfigurationBlockTypographyBlock>>("typography");
        set => SetArgument("typography", value);
    }

    /// <summary>
    /// UiColorPalette block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UiColorPalette block(s) allowed")]
    public TerraformList<AwsQuicksightThemeConfigurationBlockUiColorPaletteBlock>? UiColorPalette
    {
        get => GetArgument<TerraformList<AwsQuicksightThemeConfigurationBlockUiColorPaletteBlock>>("ui_color_palette");
        set => SetArgument("ui_color_palette", value);
    }

}

/// <summary>
/// Block type for data_color_palette in AwsQuicksightThemeConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsQuicksightThemeConfigurationBlockDataColorPaletteBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "data_color_palette";

    /// <summary>
    /// The colors attribute.
    /// </summary>
    public TerraformList<string>? Colors
    {
        get => GetArgument<TerraformList<string>>("colors");
        set => SetArgument("colors", value);
    }

    /// <summary>
    /// The empty_fill_color attribute.
    /// </summary>
    public TerraformValue<string>? EmptyFillColor
    {
        get => GetArgument<TerraformValue<string>>("empty_fill_color");
        set => SetArgument("empty_fill_color", value);
    }

    /// <summary>
    /// The min_max_gradient attribute.
    /// </summary>
    public TerraformList<string>? MinMaxGradient
    {
        get => GetArgument<TerraformList<string>>("min_max_gradient");
        set => SetArgument("min_max_gradient", value);
    }

}

/// <summary>
/// Block type for sheet in AwsQuicksightThemeConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsQuicksightThemeConfigurationBlockSheetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sheet";

    /// <summary>
    /// Tile block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Tile block(s) allowed")]
    public TerraformList<AwsQuicksightThemeConfigurationBlockSheetBlockTileBlock>? Tile
    {
        get => GetArgument<TerraformList<AwsQuicksightThemeConfigurationBlockSheetBlockTileBlock>>("tile");
        set => SetArgument("tile", value);
    }

    /// <summary>
    /// TileLayout block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TileLayout block(s) allowed")]
    public TerraformList<AwsQuicksightThemeConfigurationBlockSheetBlockTileLayoutBlock>? TileLayout
    {
        get => GetArgument<TerraformList<AwsQuicksightThemeConfigurationBlockSheetBlockTileLayoutBlock>>("tile_layout");
        set => SetArgument("tile_layout", value);
    }

}

/// <summary>
/// Block type for tile in AwsQuicksightThemeConfigurationBlockSheetBlock.
/// Nesting mode: list
/// </summary>
public class AwsQuicksightThemeConfigurationBlockSheetBlockTileBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tile";

    /// <summary>
    /// Border block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Border block(s) allowed")]
    public TerraformList<AwsQuicksightThemeConfigurationBlockSheetBlockTileBlockBorderBlock>? Border
    {
        get => GetArgument<TerraformList<AwsQuicksightThemeConfigurationBlockSheetBlockTileBlockBorderBlock>>("border");
        set => SetArgument("border", value);
    }

}

/// <summary>
/// Block type for border in AwsQuicksightThemeConfigurationBlockSheetBlockTileBlock.
/// Nesting mode: list
/// </summary>
public class AwsQuicksightThemeConfigurationBlockSheetBlockTileBlockBorderBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "border";

    /// <summary>
    /// The show attribute.
    /// </summary>
    public TerraformValue<bool>? Show
    {
        get => GetArgument<TerraformValue<bool>>("show");
        set => SetArgument("show", value);
    }

}

/// <summary>
/// Block type for tile_layout in AwsQuicksightThemeConfigurationBlockSheetBlock.
/// Nesting mode: list
/// </summary>
public class AwsQuicksightThemeConfigurationBlockSheetBlockTileLayoutBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tile_layout";

    /// <summary>
    /// Gutter block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Gutter block(s) allowed")]
    public TerraformList<AwsQuicksightThemeConfigurationBlockSheetBlockTileLayoutBlockGutterBlock>? Gutter
    {
        get => GetArgument<TerraformList<AwsQuicksightThemeConfigurationBlockSheetBlockTileLayoutBlockGutterBlock>>("gutter");
        set => SetArgument("gutter", value);
    }

    /// <summary>
    /// Margin block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Margin block(s) allowed")]
    public TerraformList<AwsQuicksightThemeConfigurationBlockSheetBlockTileLayoutBlockMarginBlock>? Margin
    {
        get => GetArgument<TerraformList<AwsQuicksightThemeConfigurationBlockSheetBlockTileLayoutBlockMarginBlock>>("margin");
        set => SetArgument("margin", value);
    }

}

/// <summary>
/// Block type for gutter in AwsQuicksightThemeConfigurationBlockSheetBlockTileLayoutBlock.
/// Nesting mode: list
/// </summary>
public class AwsQuicksightThemeConfigurationBlockSheetBlockTileLayoutBlockGutterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "gutter";

    /// <summary>
    /// The show attribute.
    /// </summary>
    public TerraformValue<bool>? Show
    {
        get => GetArgument<TerraformValue<bool>>("show");
        set => SetArgument("show", value);
    }

}

/// <summary>
/// Block type for margin in AwsQuicksightThemeConfigurationBlockSheetBlockTileLayoutBlock.
/// Nesting mode: list
/// </summary>
public class AwsQuicksightThemeConfigurationBlockSheetBlockTileLayoutBlockMarginBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "margin";

    /// <summary>
    /// The show attribute.
    /// </summary>
    public TerraformValue<bool>? Show
    {
        get => GetArgument<TerraformValue<bool>>("show");
        set => SetArgument("show", value);
    }

}

/// <summary>
/// Block type for typography in AwsQuicksightThemeConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsQuicksightThemeConfigurationBlockTypographyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "typography";

    /// <summary>
    /// FontFamilies block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(5, ErrorMessage = "Maximum 5 FontFamilies block(s) allowed")]
    public TerraformList<AwsQuicksightThemeConfigurationBlockTypographyBlockFontFamiliesBlock>? FontFamilies
    {
        get => GetArgument<TerraformList<AwsQuicksightThemeConfigurationBlockTypographyBlockFontFamiliesBlock>>("font_families");
        set => SetArgument("font_families", value);
    }

}

/// <summary>
/// Block type for font_families in AwsQuicksightThemeConfigurationBlockTypographyBlock.
/// Nesting mode: list
/// </summary>
public class AwsQuicksightThemeConfigurationBlockTypographyBlockFontFamiliesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "font_families";

    /// <summary>
    /// The font_family attribute.
    /// </summary>
    public TerraformValue<string>? FontFamily
    {
        get => GetArgument<TerraformValue<string>>("font_family");
        set => SetArgument("font_family", value);
    }

}

/// <summary>
/// Block type for ui_color_palette in AwsQuicksightThemeConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsQuicksightThemeConfigurationBlockUiColorPaletteBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ui_color_palette";

    /// <summary>
    /// The accent attribute.
    /// </summary>
    public TerraformValue<string>? Accent
    {
        get => GetArgument<TerraformValue<string>>("accent");
        set => SetArgument("accent", value);
    }

    /// <summary>
    /// The accent_foreground attribute.
    /// </summary>
    public TerraformValue<string>? AccentForeground
    {
        get => GetArgument<TerraformValue<string>>("accent_foreground");
        set => SetArgument("accent_foreground", value);
    }

    /// <summary>
    /// The danger attribute.
    /// </summary>
    public TerraformValue<string>? Danger
    {
        get => GetArgument<TerraformValue<string>>("danger");
        set => SetArgument("danger", value);
    }

    /// <summary>
    /// The danger_foreground attribute.
    /// </summary>
    public TerraformValue<string>? DangerForeground
    {
        get => GetArgument<TerraformValue<string>>("danger_foreground");
        set => SetArgument("danger_foreground", value);
    }

    /// <summary>
    /// The dimension attribute.
    /// </summary>
    public TerraformValue<string>? Dimension
    {
        get => GetArgument<TerraformValue<string>>("dimension");
        set => SetArgument("dimension", value);
    }

    /// <summary>
    /// The dimension_foreground attribute.
    /// </summary>
    public TerraformValue<string>? DimensionForeground
    {
        get => GetArgument<TerraformValue<string>>("dimension_foreground");
        set => SetArgument("dimension_foreground", value);
    }

    /// <summary>
    /// The measure attribute.
    /// </summary>
    public TerraformValue<string>? Measure
    {
        get => GetArgument<TerraformValue<string>>("measure");
        set => SetArgument("measure", value);
    }

    /// <summary>
    /// The measure_foreground attribute.
    /// </summary>
    public TerraformValue<string>? MeasureForeground
    {
        get => GetArgument<TerraformValue<string>>("measure_foreground");
        set => SetArgument("measure_foreground", value);
    }

    /// <summary>
    /// The primary_background attribute.
    /// </summary>
    public TerraformValue<string>? PrimaryBackground
    {
        get => GetArgument<TerraformValue<string>>("primary_background");
        set => SetArgument("primary_background", value);
    }

    /// <summary>
    /// The primary_foreground attribute.
    /// </summary>
    public TerraformValue<string>? PrimaryForeground
    {
        get => GetArgument<TerraformValue<string>>("primary_foreground");
        set => SetArgument("primary_foreground", value);
    }

    /// <summary>
    /// The secondary_background attribute.
    /// </summary>
    public TerraformValue<string>? SecondaryBackground
    {
        get => GetArgument<TerraformValue<string>>("secondary_background");
        set => SetArgument("secondary_background", value);
    }

    /// <summary>
    /// The secondary_foreground attribute.
    /// </summary>
    public TerraformValue<string>? SecondaryForeground
    {
        get => GetArgument<TerraformValue<string>>("secondary_foreground");
        set => SetArgument("secondary_foreground", value);
    }

    /// <summary>
    /// The success attribute.
    /// </summary>
    public TerraformValue<string>? Success
    {
        get => GetArgument<TerraformValue<string>>("success");
        set => SetArgument("success", value);
    }

    /// <summary>
    /// The success_foreground attribute.
    /// </summary>
    public TerraformValue<string>? SuccessForeground
    {
        get => GetArgument<TerraformValue<string>>("success_foreground");
        set => SetArgument("success_foreground", value);
    }

    /// <summary>
    /// The warning attribute.
    /// </summary>
    public TerraformValue<string>? Warning
    {
        get => GetArgument<TerraformValue<string>>("warning");
        set => SetArgument("warning", value);
    }

    /// <summary>
    /// The warning_foreground attribute.
    /// </summary>
    public TerraformValue<string>? WarningForeground
    {
        get => GetArgument<TerraformValue<string>>("warning_foreground");
        set => SetArgument("warning_foreground", value);
    }

}


/// <summary>
/// Block type for permissions in AwsQuicksightTheme.
/// Nesting mode: set
/// </summary>
public class AwsQuicksightThemePermissionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "permissions";

    /// <summary>
    /// The actions attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Actions is required")]
    public required TerraformSet<string> Actions
    {
        get => GetRequiredArgument<TerraformSet<string>>("actions");
        set => SetArgument("actions", value);
    }

    /// <summary>
    /// The principal attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Principal is required")]
    public required TerraformValue<string> Principal
    {
        get => GetRequiredArgument<TerraformValue<string>>("principal");
        set => SetArgument("principal", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsQuicksightTheme.
/// Nesting mode: single
/// </summary>
public class AwsQuicksightThemeTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_quicksight_theme Terraform resource.
/// Manages a aws_quicksight_theme resource.
/// </summary>
public partial class AwsQuicksightTheme(string name) : TerraformResource("aws_quicksight_theme", name)
{
    /// <summary>
    /// The aws_account_id attribute.
    /// </summary>
    public TerraformValue<string> AwsAccountId
    {
        get => GetArgument<TerraformValue<string>>("aws_account_id") ?? AsReference("aws_account_id");
        set => SetArgument("aws_account_id", value);
    }

    /// <summary>
    /// The base_theme_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BaseThemeId is required")]
    public required TerraformValue<string> BaseThemeId
    {
        get => GetRequiredArgument<TerraformValue<string>>("base_theme_id");
        set => SetArgument("base_theme_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? AsReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The theme_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ThemeId is required")]
    public required TerraformValue<string> ThemeId
    {
        get => GetRequiredArgument<TerraformValue<string>>("theme_id");
        set => SetArgument("theme_id", value);
    }

    /// <summary>
    /// The version_description attribute.
    /// </summary>
    public TerraformValue<string>? VersionDescription
    {
        get => GetArgument<TerraformValue<string>>("version_description");
        set => SetArgument("version_description", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The created_time attribute.
    /// </summary>
    public TerraformValue<string> CreatedTime
        => AsReference("created_time");

    /// <summary>
    /// The last_updated_time attribute.
    /// </summary>
    public TerraformValue<string> LastUpdatedTime
        => AsReference("last_updated_time");

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
        => AsReference("status");

    /// <summary>
    /// The version_number attribute.
    /// </summary>
    public TerraformValue<double> VersionNumber
        => AsReference("version_number");

    /// <summary>
    /// Configuration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Configuration block(s) allowed")]
    public TerraformList<AwsQuicksightThemeConfigurationBlock>? Configuration
    {
        get => GetArgument<TerraformList<AwsQuicksightThemeConfigurationBlock>>("configuration");
        set => SetArgument("configuration", value);
    }

    /// <summary>
    /// Permissions block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(64, ErrorMessage = "Maximum 64 Permissions block(s) allowed")]
    public TerraformSet<AwsQuicksightThemePermissionsBlock>? Permissions
    {
        get => GetArgument<TerraformSet<AwsQuicksightThemePermissionsBlock>>("permissions");
        set => SetArgument("permissions", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsQuicksightThemeTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsQuicksightThemeTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
