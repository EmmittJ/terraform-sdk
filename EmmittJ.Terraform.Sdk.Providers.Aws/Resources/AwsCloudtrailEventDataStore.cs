using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_cloudtrail_event_data_store resource.
/// </summary>
public class AwsCloudtrailEventDataStore : TerraformResource
{
    public AwsCloudtrailEventDataStore(string name) : base("aws_cloudtrail_event_data_store", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The billing_mode attribute.
    /// </summary>
    public string? BillingMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("billing_mode")?.Value;
        set => this.WithProperty("billing_mode", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The kms_key_id attribute.
    /// </summary>
    public string? KmsKeyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kms_key_id")?.Value;
        set => this.WithProperty("kms_key_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The multi_region_enabled attribute.
    /// </summary>
    public bool? MultiRegionEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("multi_region_enabled")?.Value;
        set => this.WithProperty("multi_region_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The organization_enabled attribute.
    /// </summary>
    public bool? OrganizationEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("organization_enabled")?.Value;
        set => this.WithProperty("organization_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The retention_period attribute.
    /// </summary>
    public double? RetentionPeriod
    {
        get => GetProperty<TerraformLiteralProperty<double>>("retention_period")?.Value;
        set => this.WithProperty("retention_period", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The suspend attribute.
    /// </summary>
    public string? Suspend
    {
        get => GetProperty<TerraformLiteralProperty<string>>("suspend")?.Value;
        set => this.WithProperty("suspend", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The termination_protection_enabled attribute.
    /// </summary>
    public bool? TerminationProtectionEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("termination_protection_enabled")?.Value;
        set => this.WithProperty("termination_protection_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
