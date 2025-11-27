using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_controltower_controls Terraform data source.
/// Retrieves information about a aws_controltower_controls.
/// </summary>
public partial class AwsControltowerControlsDataSource(string name) : TerraformDataSource("aws_controltower_controls", name)
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The target_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetIdentifier is required")]
    public required TerraformValue<string> TargetIdentifier
    {
        get => new TerraformReference<string>(this, "target_identifier");
        set => SetArgument("target_identifier", value);
    }

    /// <summary>
    /// The enabled_controls attribute.
    /// </summary>
    public TerraformList<string> EnabledControls
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "enabled_controls").ResolveNodes(ctx));
    }

}
