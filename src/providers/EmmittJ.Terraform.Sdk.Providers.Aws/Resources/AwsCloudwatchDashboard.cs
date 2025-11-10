using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_cloudwatch_dashboard resource.
/// </summary>
public class AwsCloudwatchDashboard : TerraformResource
{
    public AwsCloudwatchDashboard(string name) : base("aws_cloudwatch_dashboard", name)
    {
    }

    /// <summary>
    /// The dashboard_body attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DashboardBody is required")]
    [TerraformPropertyName("dashboard_body")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DashboardBody { get; set; }

    /// <summary>
    /// The dashboard_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DashboardName is required")]
    [TerraformPropertyName("dashboard_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DashboardName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The dashboard_arn attribute.
    /// </summary>
    [TerraformPropertyName("dashboard_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DashboardArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "dashboard_arn");

}
