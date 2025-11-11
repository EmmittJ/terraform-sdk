using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_datasync_location_object_storage resource.
/// </summary>
public class AwsDatasyncLocationObjectStorage : TerraformResource
{
    public AwsDatasyncLocationObjectStorage(string name) : base("aws_datasync_location_object_storage", name)
    {
    }

    /// <summary>
    /// The access_key attribute.
    /// </summary>
    [TerraformPropertyName("access_key")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AccessKey { get; set; }

    /// <summary>
    /// The agent_arns attribute.
    /// </summary>
    [TerraformPropertyName("agent_arns")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? AgentArns { get; set; }

    /// <summary>
    /// The bucket_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketName is required")]
    [TerraformPropertyName("bucket_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> BucketName { get; set; }

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
    /// The secret_key attribute.
    /// </summary>
    [TerraformPropertyName("secret_key")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SecretKey { get; set; }

    /// <summary>
    /// The server_certificate attribute.
    /// </summary>
    [TerraformPropertyName("server_certificate")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ServerCertificate { get; set; }

    /// <summary>
    /// The server_hostname attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerHostname is required")]
    [TerraformPropertyName("server_hostname")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ServerHostname { get; set; }

    /// <summary>
    /// The server_port attribute.
    /// </summary>
    [TerraformPropertyName("server_port")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? ServerPort { get; set; }

    /// <summary>
    /// The server_protocol attribute.
    /// </summary>
    [TerraformPropertyName("server_protocol")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ServerProtocol { get; set; }

    /// <summary>
    /// The subdirectory attribute.
    /// </summary>
    [TerraformPropertyName("subdirectory")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Subdirectory { get; set; } = default!;

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
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The uri attribute.
    /// </summary>
    [TerraformPropertyName("uri")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Uri => new TerraformReference(this, "uri");

}
