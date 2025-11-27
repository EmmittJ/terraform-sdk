using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_cloudformation_export Terraform data source.
/// Retrieves information about a aws_cloudformation_export.
/// </summary>
public partial class AwsCloudformationExportDataSource(string name) : TerraformDataSource("aws_cloudformation_export", name)
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
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
    /// The exporting_stack_id attribute.
    /// </summary>
    public TerraformValue<string> ExportingStackId
    {
        get => new TerraformReference<string>(this, "exporting_stack_id");
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
    }

}
