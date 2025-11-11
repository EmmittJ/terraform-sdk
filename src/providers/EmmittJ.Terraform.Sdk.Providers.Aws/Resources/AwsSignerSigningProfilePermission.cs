using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_signer_signing_profile_permission resource.
/// </summary>
public partial class AwsSignerSigningProfilePermission : TerraformResource
{
    public AwsSignerSigningProfilePermission(string name) : base("aws_signer_signing_profile_permission", name)
    {
    }

    /// <summary>
    /// The action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    [TerraformProperty("action")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Action { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The principal attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Principal is required")]
    [TerraformProperty("principal")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Principal { get; set; }

    /// <summary>
    /// The profile_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProfileName is required")]
    [TerraformProperty("profile_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ProfileName { get; set; }

    /// <summary>
    /// The profile_version attribute.
    /// </summary>
    [TerraformProperty("profile_version")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> ProfileVersion { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The statement_id attribute.
    /// </summary>
    [TerraformProperty("statement_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> StatementId { get; set; }

    /// <summary>
    /// The statement_id_prefix attribute.
    /// </summary>
    [TerraformProperty("statement_id_prefix")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> StatementIdPrefix { get; set; }

}
