using EmmittJ.Terraform.Sdk;

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
        get => GetProperty<TerraformLiteralProperty<string>>("account_id")?.Value;
        set => this.WithProperty("account_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The alternate_contact_type attribute.
    /// </summary>
    public string? AlternateContactType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("alternate_contact_type")?.Value;
        set => this.WithProperty("alternate_contact_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The email_address attribute.
    /// </summary>
    public string? EmailAddress
    {
        get => GetProperty<TerraformLiteralProperty<string>>("email_address")?.Value;
        set => this.WithProperty("email_address", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The phone_number attribute.
    /// </summary>
    public string? PhoneNumber
    {
        get => GetProperty<TerraformLiteralProperty<string>>("phone_number")?.Value;
        set => this.WithProperty("phone_number", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The title attribute.
    /// </summary>
    public string? Title
    {
        get => GetProperty<TerraformLiteralProperty<string>>("title")?.Value;
        set => this.WithProperty("title", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
