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
        SetOutput("global_quota");
        SetOutput("id");
        SetOutput("quota_name");
        SetOutput("service_name");
        SetOutput("unit");
        SetOutput("aws_region");
        SetOutput("quota_code");
        SetOutput("region");
        SetOutput("service_code");
        SetOutput("value");
    }

    /// <summary>
    /// The aws_region attribute.
    /// </summary>
    public TerraformProperty<string> AwsRegion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("aws_region");
        set => SetProperty("aws_region", value);
    }

    /// <summary>
    /// The quota_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QuotaCode is required")]
    public required TerraformProperty<string> QuotaCode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("quota_code");
        set => SetProperty("quota_code", value);
    }

    /// <summary>
    /// The region attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The service_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceCode is required")]
    public required TerraformProperty<string> ServiceCode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("service_code");
        set => SetProperty("service_code", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformProperty<double> Value
    {
        get => GetRequiredOutput<TerraformProperty<double>>("value");
        set => SetProperty("value", value);
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
