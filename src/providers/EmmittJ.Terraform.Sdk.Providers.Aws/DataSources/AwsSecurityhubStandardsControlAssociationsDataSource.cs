using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_securityhub_standards_control_associations Terraform data source.
/// Retrieves information about a aws_securityhub_standards_control_associations.
/// </summary>
public partial class AwsSecurityhubStandardsControlAssociationsDataSource(string name) : TerraformDataSource("aws_securityhub_standards_control_associations", name)
{
    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The security_control_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityControlId is required")]
    public required TerraformValue<string> SecurityControlId
    {
        get => new TerraformReference<string>(this, "security_control_id");
        set => SetArgument("security_control_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// The standards_control_associations attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> StandardsControlAssociations
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "standards_control_associations").ResolveNodes(ctx));
    }

}
