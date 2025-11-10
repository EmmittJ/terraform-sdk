using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_datazone_environment_blueprint.
/// </summary>
public class AwsDatazoneEnvironmentBlueprintDataSource : TerraformDataSource
{
    public AwsDatazoneEnvironmentBlueprintDataSource(string name) : base("aws_datazone_environment_blueprint", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("blueprint_provider");
        SetOutput("description");
        SetOutput("id");
        SetOutput("domain_id");
        SetOutput("managed");
        SetOutput("name");
        SetOutput("region");
    }

    /// <summary>
    /// The domain_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainId is required")]
    public required TerraformProperty<string> DomainId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("domain_id");
        set => SetProperty("domain_id", value);
    }

    /// <summary>
    /// The managed attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Managed is required")]
    public required TerraformProperty<bool> Managed
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("managed");
        set => SetProperty("managed", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The blueprint_provider attribute.
    /// </summary>
    public TerraformExpression BlueprintProvider => this["blueprint_provider"];

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}
