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
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The auth attribute.
    /// </summary>
    [TerraformPropertyName("auth")]
    // Output-only attribute - read-only reference
    public TerraformSet<object> Auth => new TerraformReference(this, "auth");

    /// <summary>
    /// The debug_logging attribute.
    /// </summary>
    [TerraformPropertyName("debug_logging")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> DebugLogging => new TerraformReference(this, "debug_logging");

    /// <summary>
    /// The default_auth_scheme attribute.
    /// </summary>
    [TerraformPropertyName("default_auth_scheme")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DefaultAuthScheme => new TerraformReference(this, "default_auth_scheme");

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [TerraformPropertyName("endpoint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Endpoint => new TerraformReference(this, "endpoint");

    /// <summary>
    /// The engine_family attribute.
    /// </summary>
    [TerraformPropertyName("engine_family")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> EngineFamily => new TerraformReference(this, "engine_family");

    /// <summary>
    /// The idle_client_timeout attribute.
    /// </summary>
    [TerraformPropertyName("idle_client_timeout")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> IdleClientTimeout => new TerraformReference(this, "idle_client_timeout");

    /// <summary>
    /// The require_tls attribute.
    /// </summary>
    [TerraformPropertyName("require_tls")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> RequireTls => new TerraformReference(this, "require_tls");

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [TerraformPropertyName("role_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> RoleArn => new TerraformReference(this, "role_arn");

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [TerraformPropertyName("vpc_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> VpcId => new TerraformReference(this, "vpc_id");

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    [TerraformPropertyName("vpc_security_group_ids")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> VpcSecurityGroupIds => new TerraformReference(this, "vpc_security_group_ids");

    /// <summary>
    /// The vpc_subnet_ids attribute.
    /// </summary>
    [TerraformPropertyName("vpc_subnet_ids")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> VpcSubnetIds => new TerraformReference(this, "vpc_subnet_ids");

}
