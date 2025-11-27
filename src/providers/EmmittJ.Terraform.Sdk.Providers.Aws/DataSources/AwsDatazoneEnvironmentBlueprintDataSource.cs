using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_datazone_environment_blueprint Terraform data source.
/// Retrieves information about a aws_datazone_environment_blueprint.
/// </summary>
public partial class AwsDatazoneEnvironmentBlueprintDataSource(string name) : TerraformDataSource("aws_datazone_environment_blueprint", name)
{
    /// <summary>
    /// The domain_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainId is required")]
    public required TerraformValue<string> DomainId
    {
        get => new TerraformReference<string>(this, "domain_id");
        set => SetArgument("domain_id", value);
    }

    /// <summary>
    /// The managed attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Managed is required")]
    public required TerraformValue<bool> Managed
    {
        get => new TerraformReference<bool>(this, "managed");
        set => SetArgument("managed", value);
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
    /// The blueprint_provider attribute.
    /// </summary>
    public TerraformValue<string> BlueprintProvider
    {
        get => new TerraformReference<string>(this, "blueprint_provider");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

}
