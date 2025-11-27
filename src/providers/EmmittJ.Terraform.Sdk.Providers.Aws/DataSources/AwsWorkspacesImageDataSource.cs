using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_workspaces_image Terraform data source.
/// Retrieves information about a aws_workspaces_image.
/// </summary>
public partial class AwsWorkspacesImageDataSource(string name) : TerraformDataSource("aws_workspaces_image", name)
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
    /// The image_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ImageId is required")]
    public required TerraformValue<string> ImageId
    {
        get => new TerraformReference<string>(this, "image_id");
        set => SetArgument("image_id", value);
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
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// The operating_system_type attribute.
    /// </summary>
    public TerraformValue<string> OperatingSystemType
    {
        get => new TerraformReference<string>(this, "operating_system_type");
    }

    /// <summary>
    /// The required_tenancy attribute.
    /// </summary>
    public TerraformValue<string> RequiredTenancy
    {
        get => new TerraformReference<string>(this, "required_tenancy");
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformValue<string> State
    {
        get => new TerraformReference<string>(this, "state");
    }

}
