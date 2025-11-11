using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_cloudwatch_event_connection.
/// </summary>
public partial class AwsCloudwatchEventConnectionDataSource : TerraformDataSource
{
    public AwsCloudwatchEventConnectionDataSource(string name) : base("aws_cloudwatch_event_connection", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The authorization_type attribute.
    /// </summary>
    [TerraformProperty("authorization_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AuthorizationType { get; }

    /// <summary>
    /// The kms_key_identifier attribute.
    /// </summary>
    [TerraformProperty("kms_key_identifier")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> KmsKeyIdentifier { get; }

    /// <summary>
    /// The secret_arn attribute.
    /// </summary>
    [TerraformProperty("secret_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SecretArn { get; }

}
