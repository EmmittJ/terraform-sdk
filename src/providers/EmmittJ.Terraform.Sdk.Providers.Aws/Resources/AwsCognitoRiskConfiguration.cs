using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for account_takeover_risk_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsCognitoRiskConfigurationAccountTakeoverRiskConfigurationBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for compromised_credentials_risk_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsCognitoRiskConfigurationCompromisedCredentialsRiskConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The event_filter attribute.
    /// </summary>
    [TerraformPropertyName("event_filter")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<string>>> EventFilter { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>("", "event_filter");

}

/// <summary>
/// Block type for risk_exception_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsCognitoRiskConfigurationRiskExceptionConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The blocked_ip_range_list attribute.
    /// </summary>
    [TerraformPropertyName("blocked_ip_range_list")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? BlockedIpRangeList { get; set; }

    /// <summary>
    /// The skipped_ip_range_list attribute.
    /// </summary>
    [TerraformPropertyName("skipped_ip_range_list")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? SkippedIpRangeList { get; set; }

}

/// <summary>
/// Manages a aws_cognito_risk_configuration resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsCognitoRiskConfiguration : TerraformResource
{
    public AwsCognitoRiskConfiguration(string name) : base("aws_cognito_risk_configuration", name)
    {
    }

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    [TerraformPropertyName("client_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ClientId { get; set; }

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
    /// The user_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserPoolId is required")]
    [TerraformPropertyName("user_pool_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> UserPoolId { get; set; }

    /// <summary>
    /// Block for account_takeover_risk_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AccountTakeoverRiskConfiguration block(s) allowed")]
    [TerraformPropertyName("account_takeover_risk_configuration")]
    public TerraformList<TerraformBlock<AwsCognitoRiskConfigurationAccountTakeoverRiskConfigurationBlock>>? AccountTakeoverRiskConfiguration { get; set; } = new();

    /// <summary>
    /// Block for compromised_credentials_risk_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CompromisedCredentialsRiskConfiguration block(s) allowed")]
    [TerraformPropertyName("compromised_credentials_risk_configuration")]
    public TerraformList<TerraformBlock<AwsCognitoRiskConfigurationCompromisedCredentialsRiskConfigurationBlock>>? CompromisedCredentialsRiskConfiguration { get; set; } = new();

    /// <summary>
    /// Block for risk_exception_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RiskExceptionConfiguration block(s) allowed")]
    [TerraformPropertyName("risk_exception_configuration")]
    public TerraformList<TerraformBlock<AwsCognitoRiskConfigurationRiskExceptionConfigurationBlock>>? RiskExceptionConfiguration { get; set; } = new();

}
