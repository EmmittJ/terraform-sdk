using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for action in .
/// Nesting mode: list
/// </summary>
public class AwsDataexchangeEventActionActionBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for event in .
/// Nesting mode: list
/// </summary>
public class AwsDataexchangeEventActionEventBlock : ITerraformBlock
{
}

/// <summary>
/// Manages a aws_dataexchange_event_action resource.
/// </summary>
public class AwsDataexchangeEventAction : TerraformResource
{
    public AwsDataexchangeEventAction(string name) : base("aws_dataexchange_event_action", name)
    {
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// Block for action.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("action")]
    public TerraformList<TerraformBlock<AwsDataexchangeEventActionActionBlock>>? Action { get; set; } = new();

    /// <summary>
    /// Block for event.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("event")]
    public TerraformList<TerraformBlock<AwsDataexchangeEventActionEventBlock>>? Event { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    [TerraformPropertyName("created_at")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreatedAt => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "created_at");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The updated_at attribute.
    /// </summary>
    [TerraformPropertyName("updated_at")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UpdatedAt => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "updated_at");

}
