using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for signing_attributes in AwsRoute53domainsDelegationSignerRecord.
/// Nesting mode: list
/// </summary>
public class AwsRoute53domainsDelegationSignerRecordSigningAttributesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "signing_attributes";

    /// <summary>
    /// The algorithm attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Algorithm is required")]
    public required TerraformValue<double> Algorithm
    {
        get => GetArgument<TerraformValue<double>>("algorithm");
        set => SetArgument("algorithm", value);
    }

    /// <summary>
    /// The flags attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Flags is required")]
    public required TerraformValue<double> Flags
    {
        get => GetArgument<TerraformValue<double>>("flags");
        set => SetArgument("flags", value);
    }

    /// <summary>
    /// The public_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PublicKey is required")]
    public required TerraformValue<string> PublicKey
    {
        get => GetArgument<TerraformValue<string>>("public_key");
        set => SetArgument("public_key", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsRoute53domainsDelegationSignerRecord.
/// Nesting mode: single
/// </summary>
public class AwsRoute53domainsDelegationSignerRecordTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

}


/// <summary>
/// Represents a aws_route53domains_delegation_signer_record Terraform resource.
/// Manages a aws_route53domains_delegation_signer_record resource.
/// </summary>
public partial class AwsRoute53domainsDelegationSignerRecord(string name) : TerraformResource("aws_route53domains_delegation_signer_record", name)
{
    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    public required TerraformValue<string> DomainName
    {
        get => GetArgument<TerraformValue<string>>("domain_name");
        set => SetArgument("domain_name", value);
    }

    /// <summary>
    /// The dnssec_key_id attribute.
    /// </summary>
    public TerraformValue<string> DnssecKeyId
        => AsReference("dnssec_key_id");

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => AsReference("id");

    /// <summary>
    /// SigningAttributes block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsRoute53domainsDelegationSignerRecordSigningAttributesBlock>? SigningAttributes
    {
        get => GetArgument<TerraformList<AwsRoute53domainsDelegationSignerRecordSigningAttributesBlock>>("signing_attributes");
        set => SetArgument("signing_attributes", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsRoute53domainsDelegationSignerRecordTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsRoute53domainsDelegationSignerRecordTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
