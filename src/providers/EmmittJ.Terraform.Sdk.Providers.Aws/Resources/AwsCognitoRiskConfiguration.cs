using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for account_takeover_risk_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsCognitoRiskConfigurationAccountTakeoverRiskConfigurationBlock() : TerraformBlock("account_takeover_risk_configuration")
{
}

/// <summary>
/// Block type for compromised_credentials_risk_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsCognitoRiskConfigurationCompromisedCredentialsRiskConfigurationBlock() : TerraformBlock("compromised_credentials_risk_configuration")
{
    /// <summary>
    /// The event_filter attribute.
    /// </summary>
    [TerraformProperty("event_filter")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformSet<string> EventFilter { get; set; }

}

/// <summary>
/// Block type for risk_exception_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsCognitoRiskConfigurationRiskExceptionConfigurationBlock() : TerraformBlock("risk_exception_configuration")
{
    /// <summary>
    /// The blocked_ip_range_list attribute.
    /// </summary>
    [TerraformProperty("blocked_ip_range_list")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? BlockedIpRangeList { get; set; }

    /// <summary>
    /// The skipped_ip_range_list attribute.
    /// </summary>
    [TerraformProperty("skipped_ip_range_list")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? SkippedIpRangeList { get; set; }

}

/// <summary>
/// Manages a aws_cognito_risk_configuration resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsCognitoRiskConfiguration : TerraformResource
{
    public AwsCognitoRiskConfiguration(string name) : base("aws_cognito_risk_configuration", name)
    {
    }

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    [TerraformProperty("client_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ClientId { get; set; }

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
    /// The user_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserPoolId is required")]
    [TerraformProperty("user_pool_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> UserPoolId { get; set; }

    /// <summary>
    /// Block for account_takeover_risk_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AccountTakeoverRiskConfiguration block(s) allowed")]
    [TerraformProperty("account_takeover_risk_configuration")]
    public TerraformList<AwsCognitoRiskConfigurationAccountTakeoverRiskConfigurationBlock> AccountTakeoverRiskConfiguration { get; set; } = new();

    /// <summary>
    /// Block for compromised_credentials_risk_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CompromisedCredentialsRiskConfiguration block(s) allowed")]
    [TerraformProperty("compromised_credentials_risk_configuration")]
    public TerraformList<AwsCognitoRiskConfigurationCompromisedCredentialsRiskConfigurationBlock> CompromisedCredentialsRiskConfiguration { get; set; } = new();

    /// <summary>
    /// Block for risk_exception_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RiskExceptionConfiguration block(s) allowed")]
    [TerraformProperty("risk_exception_configuration")]
    public TerraformList<AwsCognitoRiskConfigurationRiskExceptionConfigurationBlock> RiskExceptionConfiguration { get; set; } = new();

}
