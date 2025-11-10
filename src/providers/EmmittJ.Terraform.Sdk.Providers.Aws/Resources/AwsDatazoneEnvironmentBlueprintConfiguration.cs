using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_datazone_environment_blueprint_configuration resource.
/// </summary>
public class AwsDatazoneEnvironmentBlueprintConfiguration : TerraformResource
{
    public AwsDatazoneEnvironmentBlueprintConfiguration(string name) : base("aws_datazone_environment_blueprint_configuration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("domain_id");
        SetOutput("enabled_regions");
        SetOutput("environment_blueprint_id");
        SetOutput("manage_access_role_arn");
        SetOutput("provisioning_role_arn");
        SetOutput("region");
        SetOutput("regional_parameters");
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
    /// The enabled_regions attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnabledRegions is required")]
    public List<TerraformProperty<string>> EnabledRegions
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("enabled_regions");
        set => SetProperty("enabled_regions", value);
    }

    /// <summary>
    /// The environment_blueprint_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnvironmentBlueprintId is required")]
    public required TerraformProperty<string> EnvironmentBlueprintId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("environment_blueprint_id");
        set => SetProperty("environment_blueprint_id", value);
    }

    /// <summary>
    /// The manage_access_role_arn attribute.
    /// </summary>
    public TerraformProperty<string> ManageAccessRoleArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("manage_access_role_arn");
        set => SetProperty("manage_access_role_arn", value);
    }

    /// <summary>
    /// The provisioning_role_arn attribute.
    /// </summary>
    public TerraformProperty<string> ProvisioningRoleArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("provisioning_role_arn");
        set => SetProperty("provisioning_role_arn", value);
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
    /// The regional_parameters attribute.
    /// </summary>
    public Dictionary<string, Dictionary<string, TerraformProperty<string>>> RegionalParameters
    {
        get => GetRequiredOutput<Dictionary<string, Dictionary<string, TerraformProperty<string>>>>("regional_parameters");
        set => SetProperty("regional_parameters", value);
    }

}
