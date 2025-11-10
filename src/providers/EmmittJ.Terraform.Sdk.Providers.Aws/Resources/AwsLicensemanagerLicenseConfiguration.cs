using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_licensemanager_license_configuration resource.
/// </summary>
public class AwsLicensemanagerLicenseConfiguration : TerraformResource
{
    public AwsLicensemanagerLicenseConfiguration(string name) : base("aws_licensemanager_license_configuration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("arn");
        this.WithOutput("owner_account_id");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// The license_count attribute.
    /// </summary>
    public TerraformProperty<double>? LicenseCount
    {
        get => GetProperty<TerraformProperty<double>>("license_count");
        set => this.WithProperty("license_count", value);
    }

    /// <summary>
    /// The license_count_hard_limit attribute.
    /// </summary>
    public TerraformProperty<bool>? LicenseCountHardLimit
    {
        get => GetProperty<TerraformProperty<bool>>("license_count_hard_limit");
        set => this.WithProperty("license_count_hard_limit", value);
    }

    /// <summary>
    /// The license_counting_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LicenseCountingType is required")]
    public required TerraformProperty<string> LicenseCountingType
    {
        get => GetRequiredProperty<TerraformProperty<string>>("license_counting_type");
        set => this.WithProperty("license_counting_type", value);
    }

    /// <summary>
    /// The license_rules attribute.
    /// </summary>
    public List<TerraformProperty<string>>? LicenseRules
    {
        get => GetProperty<List<TerraformProperty<string>>>("license_rules");
        set => this.WithProperty("license_rules", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The owner_account_id attribute.
    /// </summary>
    public TerraformExpression OwnerAccountId => this["owner_account_id"];

}
