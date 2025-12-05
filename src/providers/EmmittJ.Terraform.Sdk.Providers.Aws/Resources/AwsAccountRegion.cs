using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsAccountRegion.
/// Nesting mode: single
/// </summary>
public class AwsAccountRegionTimeoutsBlock : TerraformBlock
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
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_account_region Terraform resource.
/// Manages a aws_account_region resource.
/// </summary>
public partial class AwsAccountRegion(string name) : TerraformResource("aws_account_region", name)
{
    /// <summary>
    /// The account_id attribute.
    /// </summary>
    public TerraformValue<string>? AccountId
    {
        get => GetArgument<TerraformValue<string>>("account_id");
        set => SetArgument("account_id", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The region_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RegionName is required")]
    public required TerraformValue<string> RegionName
    {
        get => GetRequiredArgument<TerraformValue<string>>("region_name");
        set => SetArgument("region_name", value);
    }

    /// <summary>
    /// The opt_status attribute.
    /// </summary>
    public TerraformValue<string> OptStatus
        => CreateReference("opt_status");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsAccountRegionTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsAccountRegionTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
