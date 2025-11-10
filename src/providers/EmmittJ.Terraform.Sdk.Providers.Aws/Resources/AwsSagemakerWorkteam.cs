using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for member_definition in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerWorkteamMemberDefinitionBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for notification_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerWorkteamNotificationConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The notification_topic_arn attribute.
    /// </summary>
    [TerraformPropertyName("notification_topic_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? NotificationTopicArn { get; set; }

}

/// <summary>
/// Block type for worker_access_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerWorkteamWorkerAccessConfigurationBlock : ITerraformBlock
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
    public required TerraformProperty<TerraformProperty<string>> Description { get; set; }

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
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// The workforce_name attribute.
    /// </summary>
    [TerraformPropertyName("workforce_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? WorkforceName { get; set; }

    /// <summary>
    /// The workteam_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkteamName is required")]
    [TerraformPropertyName("workteam_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> WorkteamName { get; set; }

    /// <summary>
    /// Block for member_definition.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MemberDefinition is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 MemberDefinition block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 MemberDefinition block(s) allowed")]
    [TerraformPropertyName("member_definition")]
    public TerraformList<TerraformBlock<AwsSagemakerWorkteamMemberDefinitionBlock>>? MemberDefinition { get; set; } = new();

    /// <summary>
    /// Block for notification_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NotificationConfiguration block(s) allowed")]
    [TerraformPropertyName("notification_configuration")]
    public TerraformList<TerraformBlock<AwsSagemakerWorkteamNotificationConfigurationBlock>>? NotificationConfiguration { get; set; } = new();

    /// <summary>
    /// Block for worker_access_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WorkerAccessConfiguration block(s) allowed")]
    [TerraformPropertyName("worker_access_configuration")]
    public TerraformList<TerraformBlock<AwsSagemakerWorkteamWorkerAccessConfigurationBlock>>? WorkerAccessConfiguration { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The subdomain attribute.
    /// </summary>
    [TerraformPropertyName("subdomain")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Subdomain => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "subdomain");

}
