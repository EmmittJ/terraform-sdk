using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_emr_supported_instance_types Terraform data source.
/// Retrieves information about a aws_emr_supported_instance_types.
/// </summary>
public partial class AwsEmrSupportedInstanceTypesDataSource(string name) : TerraformDataSource("aws_emr_supported_instance_types", name)
{
    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The release_label attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReleaseLabel is required")]
    public required TerraformValue<string> ReleaseLabel
    {
        get => GetRequiredArgument<TerraformValue<string>>("release_label");
        set => SetArgument("release_label", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => CreateReference("id");

    /// <summary>
    /// The supported_instance_types attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> SupportedInstanceTypes
        => CreateReference("supported_instance_types");

}
