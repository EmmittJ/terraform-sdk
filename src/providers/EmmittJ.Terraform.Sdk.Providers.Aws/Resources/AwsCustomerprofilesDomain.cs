using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for matching in .
/// Nesting mode: list
/// </summary>
public class AwsCustomerprofilesDomainMatchingBlock : TerraformBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformProperty<bool> Enabled
    {
        set => SetProperty("enabled", value);
    }

}

/// <summary>
/// Block type for rule_based_matching in .
/// Nesting mode: list
/// </summary>
public class AwsCustomerprofilesDomainRuleBasedMatchingBlock : TerraformBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformProperty<bool> Enabled
    {
        set => SetProperty("enabled", value);
    }

    /// <summary>
    /// The max_allowed_rule_level_for_matching attribute.
    /// </summary>
    public TerraformProperty<double>? MaxAllowedRuleLevelForMatching
    {
        set => SetProperty("max_allowed_rule_level_for_matching", value);
    }

    /// <summary>
    /// The max_allowed_rule_level_for_merging attribute.
    /// </summary>
    public TerraformProperty<double>? MaxAllowedRuleLevelForMerging
    {
        set => SetProperty("max_allowed_rule_level_for_merging", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformProperty<string>? Status
    {
        set => SetProperty("status", value);
    }

}

/// <summary>
/// Manages a aws_customerprofiles_domain resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsCustomerprofilesDomain : TerraformResource
{
    public AwsCustomerprofilesDomain(string name) : base("aws_customerprofiles_domain", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("dead_letter_queue_url");
        SetOutput("default_encryption_key");
        SetOutput("default_expiration_days");
        SetOutput("domain_name");
        SetOutput("id");
        SetOutput("region");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The dead_letter_queue_url attribute.
    /// </summary>
    public TerraformProperty<string> DeadLetterQueueUrl
    {
        get => GetRequiredOutput<TerraformProperty<string>>("dead_letter_queue_url");
        set => SetProperty("dead_letter_queue_url", value);
    }

    /// <summary>
    /// The default_encryption_key attribute.
    /// </summary>
    public TerraformProperty<string> DefaultEncryptionKey
    {
        get => GetRequiredOutput<TerraformProperty<string>>("default_encryption_key");
        set => SetProperty("default_encryption_key", value);
    }

    /// <summary>
    /// The default_expiration_days attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultExpirationDays is required")]
    public required TerraformProperty<double> DefaultExpirationDays
    {
        get => GetRequiredOutput<TerraformProperty<double>>("default_expiration_days");
        set => SetProperty("default_expiration_days", value);
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    public required TerraformProperty<string> DomainName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("domain_name");
        set => SetProperty("domain_name", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// Block for matching.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Matching block(s) allowed")]
    public List<AwsCustomerprofilesDomainMatchingBlock>? Matching
    {
        set => SetProperty("matching", value);
    }

    /// <summary>
    /// Block for rule_based_matching.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RuleBasedMatching block(s) allowed")]
    public List<AwsCustomerprofilesDomainRuleBasedMatchingBlock>? RuleBasedMatching
    {
        set => SetProperty("rule_based_matching", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
