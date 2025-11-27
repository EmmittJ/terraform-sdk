using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_securityhub_finding_aggregator Terraform resource.
/// Manages a aws_securityhub_finding_aggregator resource.
/// </summary>
public partial class AwsSecurityhubFindingAggregator(string name) : TerraformResource("aws_securityhub_finding_aggregator", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The linking_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LinkingMode is required")]
    public required TerraformValue<string> LinkingMode
    {
        get => new TerraformReference<string>(this, "linking_mode");
        set => SetArgument("linking_mode", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The specified_regions attribute.
    /// </summary>
    public TerraformSet<string>? SpecifiedRegions
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "specified_regions").ResolveNodes(ctx));
        set => SetArgument("specified_regions", value);
    }

}
