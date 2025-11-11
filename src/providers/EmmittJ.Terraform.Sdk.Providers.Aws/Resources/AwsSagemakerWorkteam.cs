using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for member_definition in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerWorkteamMemberDefinitionBlock
{
}

/// <summary>
/// Block type for notification_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerWorkteamNotificationConfigurationBlock
{
    /// <summary>
    /// The notification_topic_arn attribute.
    /// </summary>
    [TerraformPropertyName("notification_topic_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? NotificationTopicArn { get; set; }

}

/// <summary>
/// Block type for worker_access_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerWorkteamWorkerAccessConfigurationBlock
{
}

/// <summary>
/// Manages a aws_sagemaker_workteam resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsSagemakerWorkteam : TerraformResource
{
    public AwsSagemakerWorkteam(string name) : base("aws_sagemaker_workteam", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Description is required")]
    [TerraformPropertyName("description")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// The workforce_name attribute.
    /// </summary>
    [TerraformPropertyName("workforce_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? WorkforceName { get; set; }

    /// <summary>
    /// The workteam_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkteamName is required")]
    [TerraformPropertyName("workteam_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> WorkteamName { get; set; }

    /// <summary>
    /// Block for member_definition.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MemberDefinition is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 MemberDefinition block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 MemberDefinition block(s) allowed")]
    [TerraformPropertyName("member_definition")]
    public TerraformList<TerraformBlock<AwsSagemakerWorkteamMemberDefinitionBlock>>? MemberDefinition { get; set; }

    /// <summary>
    /// Block for notification_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NotificationConfiguration block(s) allowed")]
    [TerraformPropertyName("notification_configuration")]
    public TerraformList<TerraformBlock<AwsSagemakerWorkteamNotificationConfigurationBlock>>? NotificationConfiguration { get; set; }

    /// <summary>
    /// Block for worker_access_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WorkerAccessConfiguration block(s) allowed")]
    [TerraformPropertyName("worker_access_configuration")]
    public TerraformList<TerraformBlock<AwsSagemakerWorkteamWorkerAccessConfigurationBlock>>? WorkerAccessConfiguration { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The subdomain attribute.
    /// </summary>
    [TerraformPropertyName("subdomain")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Subdomain => new TerraformReference(this, "subdomain");

}
