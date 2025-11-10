using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for signing_attributes in .
/// Nesting mode: list
/// </summary>
public class AwsRoute53domainsDelegationSignerRecordSigningAttributesBlock : TerraformBlock
{
    /// <summary>
    /// The algorithm attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Algorithm is required")]
    public required TerraformProperty<double> Algorithm
    {
        set => SetProperty("algorithm", value);
    }

    /// <summary>
    /// The flags attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Flags is required")]
    public required TerraformProperty<double> Flags
    {
        set => SetProperty("flags", value);
    }

    /// <summary>
    /// The public_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PublicKey is required")]
    public required TerraformProperty<string> PublicKey
    {
        set => SetProperty("public_key", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsRoute53domainsDelegationSignerRecordTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

}

/// <summary>
/// Manages a aws_route53domains_delegation_signer_record resource.
/// </summary>
public class AwsRoute53domainsDelegationSignerRecord : TerraformResource
{
    public AwsRoute53domainsDelegationSignerRecord(string name) : base("aws_route53domains_delegation_signer_record", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("dnssec_key_id");
        SetOutput("id");
        SetOutput("domain_name");
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
    /// Block for signing_attributes.
    /// Nesting mode: list
    /// </summary>
    public List<AwsRoute53domainsDelegationSignerRecordSigningAttributesBlock>? SigningAttributes
    {
        set => SetProperty("signing_attributes", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsRoute53domainsDelegationSignerRecordTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The dnssec_key_id attribute.
    /// </summary>
    public TerraformExpression DnssecKeyId => this["dnssec_key_id"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}
