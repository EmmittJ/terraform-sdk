using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in AwsSsmPatchBaselinesDataSource.
/// Nesting mode: list
/// </summary>
public class AwsSsmPatchBaselinesDataSourceFilterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "filter";

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => GetRequiredArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public required TerraformSet<string> ValuesAttribute
    {
        get => GetRequiredArgument<TerraformSet<string>>("values");
        set => SetArgument("values", value);
    }

}


/// <summary>
/// Represents a aws_ssm_patch_baselines Terraform data source.
/// Retrieves information about a aws_ssm_patch_baselines.
/// </summary>
public partial class AwsSsmPatchBaselinesDataSource(string name) : TerraformDataSource("aws_ssm_patch_baselines", name)
{
    /// <summary>
    /// The default_baselines attribute.
    /// </summary>
    public TerraformValue<bool>? DefaultBaselines
    {
        get => GetArgument<TerraformValue<bool>>("default_baselines");
        set => SetArgument("default_baselines", value);
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
    /// The baseline_identities attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> BaselineIdentities
        => AsReference("baseline_identities");

    /// <summary>
    /// Filter block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsSsmPatchBaselinesDataSourceFilterBlock>? Filter
    {
        get => GetArgument<TerraformList<AwsSsmPatchBaselinesDataSourceFilterBlock>>("filter");
        set => SetArgument("filter", value);
    }

}
