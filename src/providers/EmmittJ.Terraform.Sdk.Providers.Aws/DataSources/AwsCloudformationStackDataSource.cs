using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_cloudformation_stack.
/// </summary>
public class AwsCloudformationStackDataSource : TerraformDataSource
{
    public AwsCloudformationStackDataSource(string name) : base("aws_cloudformation_stack", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The capabilities attribute.
    /// </summary>
    [TerraformPropertyName("capabilities")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> Capabilities => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "capabilities");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Description => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// The disable_rollback attribute.
    /// </summary>
    [TerraformPropertyName("disable_rollback")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> DisableRollback => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "disable_rollback");

    /// <summary>
    /// The iam_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("iam_role_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> IamRoleArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "iam_role_arn");

    /// <summary>
    /// The notification_arns attribute.
    /// </summary>
    [TerraformPropertyName("notification_arns")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> NotificationArns => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "notification_arns");

    /// <summary>
    /// The outputs attribute.
    /// </summary>
    [TerraformPropertyName("outputs")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Outputs => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "outputs");

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    [TerraformPropertyName("parameters")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Parameters => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "parameters");

    /// <summary>
    /// The template_body attribute.
    /// </summary>
    [TerraformPropertyName("template_body")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TemplateBody => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "template_body");

    /// <summary>
    /// The timeout_in_minutes attribute.
    /// </summary>
    [TerraformPropertyName("timeout_in_minutes")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> TimeoutInMinutes => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "timeout_in_minutes");

}
