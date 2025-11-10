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
        get => GetProperty<HashSet<TerraformProperty<string>>>("event_filter");
        set => WithProperty("event_filter", value);
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
        get => GetProperty<HashSet<TerraformProperty<string>>>("blocked_ip_range_list");
        set => WithProperty("blocked_ip_range_list", value);
    }

    /// <summary>
    /// The skipped_ip_range_list attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? SkippedIpRangeList
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("skipped_ip_range_list");
        set => WithProperty("skipped_ip_range_list", value);
    }

}

/// <summary>
/// Manages a aws_cognito_risk_configuration resource.
/// </summary>
public class AwsCognitoRiskConfiguration : TerraformResource
{
    public AwsCognitoRiskConfiguration(string name) : base("aws_cognito_risk_configuration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    public TerraformProperty<string>? ClientId
    {
        get => GetProperty<TerraformProperty<string>>("client_id");
        set => this.WithProperty("client_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The user_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserPoolId is required")]
    public required TerraformProperty<string> UserPoolId
    {
        get => GetProperty<TerraformProperty<string>>("user_pool_id");
        set => this.WithProperty("user_pool_id", value);
    }

    /// <summary>
    /// Block for account_takeover_risk_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AccountTakeoverRiskConfiguration block(s) allowed")]
    public List<AwsCognitoRiskConfigurationAccountTakeoverRiskConfigurationBlock>? AccountTakeoverRiskConfiguration
    {
        get => GetProperty<List<AwsCognitoRiskConfigurationAccountTakeoverRiskConfigurationBlock>>("account_takeover_risk_configuration");
        set => this.WithProperty("account_takeover_risk_configuration", value);
    }

    /// <summary>
    /// Block for compromised_credentials_risk_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CompromisedCredentialsRiskConfiguration block(s) allowed")]
    public List<AwsCognitoRiskConfigurationCompromisedCredentialsRiskConfigurationBlock>? CompromisedCredentialsRiskConfiguration
    {
        get => GetProperty<List<AwsCognitoRiskConfigurationCompromisedCredentialsRiskConfigurationBlock>>("compromised_credentials_risk_configuration");
        set => this.WithProperty("compromised_credentials_risk_configuration", value);
    }

    /// <summary>
    /// Block for risk_exception_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RiskExceptionConfiguration block(s) allowed")]
    public List<AwsCognitoRiskConfigurationRiskExceptionConfigurationBlock>? RiskExceptionConfiguration
    {
        get => GetProperty<List<AwsCognitoRiskConfigurationRiskExceptionConfigurationBlock>>("risk_exception_configuration");
        set => this.WithProperty("risk_exception_configuration", value);
    }

}
