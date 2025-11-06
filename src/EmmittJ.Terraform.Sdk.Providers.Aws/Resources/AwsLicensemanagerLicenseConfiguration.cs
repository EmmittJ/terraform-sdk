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
        this.DeclareOutput("arn");
        this.DeclareOutput("owner_account_id");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The license_count attribute.
    /// </summary>
    public double? LicenseCount
    {
        get => GetProperty<TerraformLiteralProperty<double>>("license_count")?.Value;
        set => this.WithProperty("license_count", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The license_count_hard_limit attribute.
    /// </summary>
    public bool? LicenseCountHardLimit
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("license_count_hard_limit")?.Value;
        set => this.WithProperty("license_count_hard_limit", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The license_counting_type attribute.
    /// </summary>
    public string? LicenseCountingType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("license_counting_type")?.Value;
        set => this.WithProperty("license_counting_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The license_rules attribute.
    /// </summary>
    public List<string>? LicenseRules
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("license_rules")?.Value;
        set => this.WithProperty("license_rules", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
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
