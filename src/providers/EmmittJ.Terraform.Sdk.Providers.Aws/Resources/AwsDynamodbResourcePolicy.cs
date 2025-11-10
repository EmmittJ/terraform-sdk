using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_dynamodb_resource_policy resource.
/// </summary>
public class AwsDynamodbResourcePolicy : TerraformResource
{
    public AwsDynamodbResourcePolicy(string name) : base("aws_dynamodb_resource_policy", name)
    {
    }

    /// <summary>
    /// The confirm_remove_self_resource_access attribute.
    /// </summary>
    [TerraformPropertyName("confirm_remove_self_resource_access")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> ConfirmRemoveSelfResourceAccess { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "confirm_remove_self_resource_access");

    /// <summary>
    /// The policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Policy is required")]
    [TerraformPropertyName("policy")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Policy { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The resource_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceArn is required")]
    [TerraformPropertyName("resource_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceArn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The revision_id attribute.
    /// </summary>
    [TerraformPropertyName("revision_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> RevisionId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "revision_id");

}
