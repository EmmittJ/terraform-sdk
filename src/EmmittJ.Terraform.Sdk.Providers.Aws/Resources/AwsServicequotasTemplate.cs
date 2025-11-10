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
    /// The aws_region attribute.
    /// </summary>
    public TerraformProperty<string>? AwsRegion
    {
        get => GetProperty<TerraformProperty<string>>("aws_region");
        set => this.WithProperty("aws_region", value);
    }

    /// <summary>
    /// The quota_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QuotaCode is required")]
    public required TerraformProperty<string> QuotaCode
    {
        get => GetRequiredProperty<TerraformProperty<string>>("quota_code");
        set => this.WithProperty("quota_code", value);
    }

    /// <summary>
    /// The region attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The service_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceCode is required")]
    public required TerraformProperty<string> ServiceCode
    {
        get => GetRequiredProperty<TerraformProperty<string>>("service_code");
        set => this.WithProperty("service_code", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformProperty<double> Value
    {
        get => GetRequiredProperty<TerraformProperty<double>>("value");
        set => this.WithProperty("value", value);
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
