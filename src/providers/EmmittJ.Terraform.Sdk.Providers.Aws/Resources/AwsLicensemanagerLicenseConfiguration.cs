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
        SetOutput("arn");
        SetOutput("owner_account_id");
        SetOutput("description");
        SetOutput("id");
        SetOutput("license_count");
        SetOutput("license_count_hard_limit");
        SetOutput("license_counting_type");
        SetOutput("license_rules");
        SetOutput("name");
        SetOutput("region");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
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
    /// The license_count attribute.
    /// </summary>
    public TerraformProperty<double> LicenseCount
    {
        get => GetRequiredOutput<TerraformProperty<double>>("license_count");
        set => SetProperty("license_count", value);
    }

    /// <summary>
    /// The license_count_hard_limit attribute.
    /// </summary>
    public TerraformProperty<bool> LicenseCountHardLimit
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("license_count_hard_limit");
        set => SetProperty("license_count_hard_limit", value);
    }

    /// <summary>
    /// The license_counting_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LicenseCountingType is required")]
    public required TerraformProperty<string> LicenseCountingType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("license_counting_type");
        set => SetProperty("license_counting_type", value);
    }

    /// <summary>
    /// The license_rules attribute.
    /// </summary>
    public List<TerraformProperty<string>> LicenseRules
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("license_rules");
        set => SetProperty("license_rules", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
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
