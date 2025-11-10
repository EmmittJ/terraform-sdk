using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for account_takeover_risk_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsCognitoRiskConfigurationAccountTakeoverRiskConfigurationBlock : TerraformBlock
{
}

/// <summary>
/// Block type for compromised_credentials_risk_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsCognitoRiskConfigurationCompromisedCredentialsRiskConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The event_filter attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? EventFilter
    {
        set => SetProperty("event_filter", value);
    }

}

/// <summary>
/// Block type for risk_exception_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsCognitoRiskConfigurationRiskExceptionConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The blocked_ip_range_list attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? BlockedIpRangeList
    {
        set => SetProperty("blocked_ip_range_list", value);
    }

    /// <summary>
    /// The skipped_ip_range_list attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? SkippedIpRangeList
    {
        set => SetProperty("skipped_ip_range_list", value);
    }

}

/// <summary>
/// Manages a aws_cognito_risk_configuration resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsCognitoRiskConfiguration : TerraformResource
{
    public AwsCognitoRiskConfiguration(string name) : base("aws_cognito_risk_configuration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("client_id");
        SetOutput("id");
        SetOutput("region");
        SetOutput("user_pool_id");
    }

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    public TerraformProperty<string> ClientId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("client_id");
        set => SetProperty("client_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The user_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserPoolId is required")]
    public required TerraformProperty<string> UserPoolId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("user_pool_id");
        set => SetProperty("user_pool_id", value);
    }

    /// <summary>
    /// Block for account_takeover_risk_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AccountTakeoverRiskConfiguration block(s) allowed")]
    public List<AwsCognitoRiskConfigurationAccountTakeoverRiskConfigurationBlock>? AccountTakeoverRiskConfiguration
    {
        set => SetProperty("account_takeover_risk_configuration", value);
    }

    /// <summary>
    /// Block for compromised_credentials_risk_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CompromisedCredentialsRiskConfiguration block(s) allowed")]
    public List<AwsCognitoRiskConfigurationCompromisedCredentialsRiskConfigurationBlock>? CompromisedCredentialsRiskConfiguration
    {
        set => SetProperty("compromised_credentials_risk_configuration", value);
    }

    /// <summary>
    /// Block for risk_exception_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RiskExceptionConfiguration block(s) allowed")]
    public List<AwsCognitoRiskConfigurationRiskExceptionConfigurationBlock>? RiskExceptionConfiguration
    {
        set => SetProperty("risk_exception_configuration", value);
    }

}
