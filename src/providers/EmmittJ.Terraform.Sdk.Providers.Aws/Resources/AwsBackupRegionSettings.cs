using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_backup_region_settings resource.
/// </summary>
public class AwsBackupRegionSettings : TerraformResource
{
    public AwsBackupRegionSettings(string name) : base("aws_backup_region_settings", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("id");
        SetOutput("region");
        SetOutput("resource_type_management_preference");
        SetOutput("resource_type_opt_in_preference");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
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
    /// The resource_type_management_preference attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<bool>> ResourceTypeManagementPreference
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<bool>>>("resource_type_management_preference");
        set => SetProperty("resource_type_management_preference", value);
    }

    /// <summary>
    /// The resource_type_opt_in_preference attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceTypeOptInPreference is required")]
    public Dictionary<string, TerraformProperty<bool>> ResourceTypeOptInPreference
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<bool>>>("resource_type_opt_in_preference");
        set => SetProperty("resource_type_opt_in_preference", value);
    }

}
