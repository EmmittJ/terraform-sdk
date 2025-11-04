using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_servicequotas_template resource.
/// </summary>
public class AwsServicequotasTemplate : TerraformResource
{
    public AwsServicequotasTemplate(string name) : base("aws_servicequotas_template", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("global_quota");
        this.DeclareOutput("id");
        this.DeclareOutput("quota_name");
        this.DeclareOutput("service_name");
        this.DeclareOutput("unit");
    }

    /// <summary>
    /// The quota_code attribute.
    /// </summary>
    public string? QuotaCode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("quota_code")?.Value;
        set => this.WithProperty("quota_code", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The region attribute.
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The service_code attribute.
    /// </summary>
    public string? ServiceCode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_code")?.Value;
        set => this.WithProperty("service_code", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public double? Value
    {
        get => GetProperty<TerraformLiteralProperty<double>>("value")?.Value;
        set => this.WithProperty("value", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The global_quota attribute.
    /// </summary>
    public TerraformExpression GlobalQuota => this["global_quota"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The quota_name attribute.
    /// </summary>
    public TerraformExpression QuotaName => this["quota_name"];

    /// <summary>
    /// The service_name attribute.
    /// </summary>
    public TerraformExpression ServiceName => this["service_name"];

    /// <summary>
    /// The unit attribute.
    /// </summary>
    public TerraformExpression Unit => this["unit"];

}
