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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
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
        get => new TerraformReference<string>(this, "account_id");
        set => SetArgument("account_id", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The region_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RegionName is required")]
    public required TerraformValue<string> RegionName
    {
        get => new TerraformReference<string>(this, "region_name");
        set => SetArgument("region_name", value);
    }

    /// <summary>
    /// The opt_status attribute.
    /// </summary>
    public TerraformValue<string> OptStatus
    {
        get => new TerraformReference<string>(this, "opt_status");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsAccountRegionTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsAccountRegionTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
