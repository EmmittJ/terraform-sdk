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
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The resource_type_management_preference attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, bool>>? ResourceTypeManagementPreference
    {
        get => GetProperty<TerraformProperty<Dictionary<string, bool>>>("resource_type_management_preference");
        set => this.WithProperty("resource_type_management_preference", value);
    }

    /// <summary>
    /// The resource_type_opt_in_preference attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, bool>>? ResourceTypeOptInPreference
    {
        get => GetProperty<TerraformProperty<Dictionary<string, bool>>>("resource_type_opt_in_preference");
        set => this.WithProperty("resource_type_opt_in_preference", value);
    }

}
