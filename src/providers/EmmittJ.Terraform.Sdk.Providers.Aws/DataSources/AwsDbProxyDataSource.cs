using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_db_proxy.
/// </summary>
public class AwsDbProxyDataSource : TerraformDataSource
{
    public AwsDbProxyDataSource(string name) : base("aws_db_proxy", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The auth attribute.
    /// </summary>
    [TerraformPropertyName("auth")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<object>>> Auth => new TerraformReferenceProperty<HashSet<TerraformProperty<object>>>(ResourceAddress, "auth");

    /// <summary>
    /// The debug_logging attribute.
    /// </summary>
    [TerraformPropertyName("debug_logging")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> DebugLogging => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "debug_logging");

    /// <summary>
    /// The default_auth_scheme attribute.
    /// </summary>
    [TerraformPropertyName("default_auth_scheme")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DefaultAuthScheme => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "default_auth_scheme");

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [TerraformPropertyName("endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Endpoint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "endpoint");

    /// <summary>
    /// The engine_family attribute.
    /// </summary>
    [TerraformPropertyName("engine_family")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> EngineFamily => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "engine_family");

    /// <summary>
    /// The idle_client_timeout attribute.
    /// </summary>
    [TerraformPropertyName("idle_client_timeout")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> IdleClientTimeout => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "idle_client_timeout");

    /// <summary>
    /// The require_tls attribute.
    /// </summary>
    [TerraformPropertyName("require_tls")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> RequireTls => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "require_tls");

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [TerraformPropertyName("role_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> RoleArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "role_arn");

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [TerraformPropertyName("vpc_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VpcId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "vpc_id");

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    [TerraformPropertyName("vpc_security_group_ids")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> VpcSecurityGroupIds => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "vpc_security_group_ids");

    /// <summary>
    /// The vpc_subnet_ids attribute.
    /// </summary>
    [TerraformPropertyName("vpc_subnet_ids")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> VpcSubnetIds => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "vpc_subnet_ids");

}
