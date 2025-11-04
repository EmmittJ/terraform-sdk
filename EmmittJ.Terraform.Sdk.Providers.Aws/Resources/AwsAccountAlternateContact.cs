using EmmittJ.Terraform.Sdk.Resources;
using EmmittJ.Terraform.Sdk.Context;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_account_alternate_contact resource.
/// </summary>
public class AwsAccountAlternateContact : TerraformResource
{
    public AwsAccountAlternateContact(string name) : base("aws_account_alternate_contact", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    public string? AccountId
    {
        get => GetProperty<TerraformLiteralProperty&lt;string&gt;>("account_id")?.Value;
        set => WithPropertyInternal("account_id", value == null ? null : new TerraformLiteralProperty&lt;string&gt;(value));
    }

    /// <summary>
    /// The alternate_contact_type attribute.
    /// </summary>
    public string? AlternateContactType
    {
        get => GetProperty<TerraformLiteralProperty&lt;string&gt;>("alternate_contact_type")?.Value;
        set => WithPropertyInternal("alternate_contact_type", value == null ? null : new TerraformLiteralProperty&lt;string&gt;(value));
    }

    /// <summary>
    /// The email_address attribute.
    /// </summary>
    public string? EmailAddress
    {
        get => GetProperty<TerraformLiteralProperty&lt;string&gt;>("email_address")?.Value;
        set => WithPropertyInternal("email_address", value == null ? null : new TerraformLiteralProperty&lt;string&gt;(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty&lt;string&gt;>("id")?.Value;
        set => WithPropertyInternal("id", value == null ? null : new TerraformLiteralProperty&lt;string&gt;(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty&lt;string&gt;>("name")?.Value;
        set => WithPropertyInternal("name", value == null ? null : new TerraformLiteralProperty&lt;string&gt;(value));
    }

    /// <summary>
    /// The phone_number attribute.
    /// </summary>
    public string? PhoneNumber
    {
        get => GetProperty<TerraformLiteralProperty&lt;string&gt;>("phone_number")?.Value;
        set => WithPropertyInternal("phone_number", value == null ? null : new TerraformLiteralProperty&lt;string&gt;(value));
    }

    /// <summary>
    /// The title attribute.
    /// </summary>
    public string? Title
    {
        get => GetProperty<TerraformLiteralProperty&lt;string&gt;>("title")?.Value;
        set => WithPropertyInternal("title", value == null ? null : new TerraformLiteralProperty&lt;string&gt;(value));
    }

}
