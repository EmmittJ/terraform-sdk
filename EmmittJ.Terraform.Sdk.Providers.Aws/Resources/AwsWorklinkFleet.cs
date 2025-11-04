using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_worklink_fleet resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
public class AwsWorklinkFleet : TerraformResource
{
    public AwsWorklinkFleet(string name) : base("aws_worklink_fleet", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("company_code");
        this.DeclareOutput("created_time");
        this.DeclareOutput("last_updated_time");
    }

    /// <summary>
    /// The audit_stream_arn attribute.
    /// </summary>
    public string? AuditStreamArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("audit_stream_arn")?.Value;
        set => this.WithProperty("audit_stream_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The device_ca_certificate attribute.
    /// </summary>
    public string? DeviceCaCertificate
    {
        get => GetProperty<TerraformLiteralProperty<string>>("device_ca_certificate")?.Value;
        set => this.WithProperty("device_ca_certificate", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public string? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name")?.Value;
        set => this.WithProperty("display_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The optimize_for_end_user_location attribute.
    /// </summary>
    public bool? OptimizeForEndUserLocation
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("optimize_for_end_user_location")?.Value;
        set => this.WithProperty("optimize_for_end_user_location", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The company_code attribute.
    /// </summary>
    public TerraformExpression CompanyCode => this["company_code"];

    /// <summary>
    /// The created_time attribute.
    /// </summary>
    public TerraformExpression CreatedTime => this["created_time"];

    /// <summary>
    /// The last_updated_time attribute.
    /// </summary>
    public TerraformExpression LastUpdatedTime => this["last_updated_time"];

}
