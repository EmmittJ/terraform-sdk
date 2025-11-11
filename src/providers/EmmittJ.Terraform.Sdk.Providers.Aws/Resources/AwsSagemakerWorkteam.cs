using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for member_definition in .
/// Nesting mode: list
/// </summary>
public partial class AwsSagemakerWorkteamMemberDefinitionBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for notification_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsSagemakerWorkteamNotificationConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The notification_topic_arn attribute.
    /// </summary>
    [TerraformProperty("notification_topic_arn")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? NotificationTopicArn { get; set; }

}

/// <summary>
/// Block type for worker_access_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsSagemakerWorkteamWorkerAccessConfigurationBlock : TerraformBlockBase
{
}

/// <summary>
/// Manages a aws_sagemaker_workteam resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsSagemakerWorkteam : TerraformResource
{
    public AwsSagemakerWorkteam(string name) : base("aws_sagemaker_workteam", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Description is required")]
    [TerraformProperty("description")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The workforce_name attribute.
    /// </summary>
    [TerraformProperty("workforce_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? WorkforceName { get; set; }

    /// <summary>
    /// The workteam_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkteamName is required")]
    [TerraformProperty("workteam_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> WorkteamName { get; set; }

    /// <summary>
    /// Block for member_definition.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MemberDefinition is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 MemberDefinition block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 MemberDefinition block(s) allowed")]
    [TerraformProperty("member_definition")]
    public TerraformList<TerraformBlock<AwsSagemakerWorkteamMemberDefinitionBlock>>? MemberDefinition { get; set; }

    /// <summary>
    /// Block for notification_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NotificationConfiguration block(s) allowed")]
    [TerraformProperty("notification_configuration")]
    public TerraformList<TerraformBlock<AwsSagemakerWorkteamNotificationConfigurationBlock>>? NotificationConfiguration { get; set; }

    /// <summary>
    /// Block for worker_access_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WorkerAccessConfiguration block(s) allowed")]
    [TerraformProperty("worker_access_configuration")]
    public TerraformList<TerraformBlock<AwsSagemakerWorkteamWorkerAccessConfigurationBlock>>? WorkerAccessConfiguration { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The subdomain attribute.
    /// </summary>
    [TerraformProperty("subdomain")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Subdomain { get; }

}
