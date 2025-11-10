using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for auth_request in .
/// Nesting mode: list
/// </summary>
public class AwsAppfabricAppAuthorizationConnectionAuthRequestBlock : ITerraformBlock
{
    /// <summary>
    /// The code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Code is required")]
    [TerraformPropertyName("code")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Code { get; set; }

    /// <summary>
    /// The redirect_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RedirectUri is required")]
    [TerraformPropertyName("redirect_uri")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RedirectUri { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsAppfabricAppAuthorizationConnectionTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

}

/// <summary>
/// Manages a aws_appfabric_app_authorization_connection resource.
/// </summary>
public class AwsAppfabricAppAuthorizationConnection : TerraformResource
{
    public AwsAppfabricAppAuthorizationConnection(string name) : base("aws_appfabric_app_authorization_connection", name)
    {
    }

    /// <summary>
    /// The app_authorization_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppAuthorizationArn is required")]
    [TerraformPropertyName("app_authorization_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AppAuthorizationArn { get; set; }

    /// <summary>
    /// The app_bundle_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppBundleArn is required")]
    [TerraformPropertyName("app_bundle_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AppBundleArn { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// Block for auth_request.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("auth_request")]
    public TerraformList<TerraformBlock<AwsAppfabricAppAuthorizationConnectionAuthRequestBlock>>? AuthRequest { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsAppfabricAppAuthorizationConnectionTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The app attribute.
    /// </summary>
    [TerraformPropertyName("app")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> App => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "app");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The tenant attribute.
    /// </summary>
    [TerraformPropertyName("tenant")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Tenant => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "tenant");

}
