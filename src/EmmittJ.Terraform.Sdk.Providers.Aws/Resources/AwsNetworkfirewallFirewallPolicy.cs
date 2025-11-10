using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for encryption_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsNetworkfirewallFirewallPolicyEncryptionConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The key_id attribute.
    /// </summary>
    public TerraformProperty<string>? KeyId
    {
        get => GetProperty<TerraformProperty<string>>("key_id");
        set => WithProperty("key_id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetRequiredProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Block type for firewall_policy in .
/// Nesting mode: list
/// </summary>
public class AwsNetworkfirewallFirewallPolicyFirewallPolicyBlock : TerraformBlock
{
    /// <summary>
    /// The stateful_default_actions attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? StatefulDefaultActions
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("stateful_default_actions");
        set => WithProperty("stateful_default_actions", value);
    }

    /// <summary>
    /// The stateless_default_actions attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StatelessDefaultActions is required")]
    public HashSet<TerraformProperty<string>>? StatelessDefaultActions
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("stateless_default_actions");
        set => WithProperty("stateless_default_actions", value);
    }

    /// <summary>
    /// The stateless_fragment_default_actions attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StatelessFragmentDefaultActions is required")]
    public HashSet<TerraformProperty<string>>? StatelessFragmentDefaultActions
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("stateless_fragment_default_actions");
        set => WithProperty("stateless_fragment_default_actions", value);
    }

    /// <summary>
    /// The tls_inspection_configuration_arn attribute.
    /// </summary>
    public TerraformProperty<string>? TlsInspectionConfigurationArn
    {
        get => GetProperty<TerraformProperty<string>>("tls_inspection_configuration_arn");
        set => WithProperty("tls_inspection_configuration_arn", value);
    }

}

/// <summary>
/// Manages a aws_networkfirewall_firewall_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsNetworkfirewallFirewallPolicy : TerraformResource
{
    public AwsNetworkfirewallFirewallPolicy(string name) : base("aws_networkfirewall_firewall_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("update_token");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    /// Block for encryption_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionConfiguration block(s) allowed")]
    public List<AwsNetworkfirewallFirewallPolicyEncryptionConfigurationBlock>? EncryptionConfiguration
    {
        get => GetProperty<List<AwsNetworkfirewallFirewallPolicyEncryptionConfigurationBlock>>("encryption_configuration");
        set => this.WithProperty("encryption_configuration", value);
    }

    /// <summary>
    /// Block for firewall_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 FirewallPolicy block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FirewallPolicy block(s) allowed")]
    public List<AwsNetworkfirewallFirewallPolicyFirewallPolicyBlock>? FirewallPolicy
    {
        get => GetProperty<List<AwsNetworkfirewallFirewallPolicyFirewallPolicyBlock>>("firewall_policy");
        set => this.WithProperty("firewall_policy", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The update_token attribute.
    /// </summary>
    public TerraformExpression UpdateToken => this["update_token"];

}
