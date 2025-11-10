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
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => WithProperty("enabled", value);
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
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => WithProperty("enabled", value);
    }

    /// <summary>
    /// The max_allowed_rule_level_for_matching attribute.
    /// </summary>
    public TerraformProperty<double>? MaxAllowedRuleLevelForMatching
    {
        get => GetProperty<TerraformProperty<double>>("max_allowed_rule_level_for_matching");
        set => WithProperty("max_allowed_rule_level_for_matching", value);
    }

    /// <summary>
    /// The max_allowed_rule_level_for_merging attribute.
    /// </summary>
    public TerraformProperty<double>? MaxAllowedRuleLevelForMerging
    {
        get => GetProperty<TerraformProperty<double>>("max_allowed_rule_level_for_merging");
        set => WithProperty("max_allowed_rule_level_for_merging", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformProperty<string>? Status
    {
        get => GetProperty<TerraformProperty<string>>("status");
        set => WithProperty("status", value);
    }

}

/// <summary>
/// Manages a aws_customerprofiles_domain resource.
/// </summary>
public class AwsCustomerprofilesDomain : TerraformResource
{
    public AwsCustomerprofilesDomain(string name) : base("aws_customerprofiles_domain", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The dead_letter_queue_url attribute.
    /// </summary>
    public TerraformProperty<string>? DeadLetterQueueUrl
    {
        get => GetProperty<TerraformProperty<string>>("dead_letter_queue_url");
        set => this.WithProperty("dead_letter_queue_url", value);
    }

    /// <summary>
    /// The default_encryption_key attribute.
    /// </summary>
    public TerraformProperty<string>? DefaultEncryptionKey
    {
        get => GetProperty<TerraformProperty<string>>("default_encryption_key");
        set => this.WithProperty("default_encryption_key", value);
    }

    /// <summary>
    /// The default_expiration_days attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultExpirationDays is required")]
    public required TerraformProperty<double> DefaultExpirationDays
    {
        get => GetProperty<TerraformProperty<double>>("default_expiration_days");
        set => this.WithProperty("default_expiration_days", value);
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    public required TerraformProperty<string> DomainName
    {
        get => GetProperty<TerraformProperty<string>>("domain_name");
        set => this.WithProperty("domain_name", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// Block for matching.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Matching block(s) allowed")]
    public List<AwsCustomerprofilesDomainMatchingBlock>? Matching
    {
        get => GetProperty<List<AwsCustomerprofilesDomainMatchingBlock>>("matching");
        set => this.WithProperty("matching", value);
    }

    /// <summary>
    /// Block for rule_based_matching.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RuleBasedMatching block(s) allowed")]
    public List<AwsCustomerprofilesDomainRuleBasedMatchingBlock>? RuleBasedMatching
    {
        get => GetProperty<List<AwsCustomerprofilesDomainRuleBasedMatchingBlock>>("rule_based_matching");
        set => this.WithProperty("rule_based_matching", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
