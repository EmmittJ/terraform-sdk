using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_datasync_location_object_storage resource.
/// </summary>
public partial class AwsDatasyncLocationObjectStorage : TerraformResource
{
    public AwsDatasyncLocationObjectStorage(string name) : base("aws_datasync_location_object_storage", name)
    {
    }

    /// <summary>
    /// The access_key attribute.
    /// </summary>
    [TerraformProperty("access_key")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AccessKey { get; set; }

    /// <summary>
    /// The agent_arns attribute.
    /// </summary>
    [TerraformProperty("agent_arns")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? AgentArns { get; set; }

    /// <summary>
    /// The bucket_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketName is required")]
    [TerraformProperty("bucket_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> BucketName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The secret_key attribute.
    /// </summary>
    [TerraformProperty("secret_key")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SecretKey { get; set; }

    /// <summary>
    /// The server_certificate attribute.
    /// </summary>
    [TerraformProperty("server_certificate")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ServerCertificate { get; set; }

    /// <summary>
    /// The server_hostname attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerHostname is required")]
    [TerraformProperty("server_hostname")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ServerHostname { get; set; }

    /// <summary>
    /// The server_port attribute.
    /// </summary>
    [TerraformProperty("server_port")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? ServerPort { get; set; }

    /// <summary>
    /// The server_protocol attribute.
    /// </summary>
    [TerraformProperty("server_protocol")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ServerProtocol { get; set; }

    /// <summary>
    /// The subdirectory attribute.
    /// </summary>
    [TerraformProperty("subdirectory")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Subdirectory { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    [TerraformProperty("uri")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Uri { get; }

}
