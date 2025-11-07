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
    public TerraformLiteralProperty<string>? AccountId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("account_id");
        set => this.WithProperty("account_id", value);
    }

    /// <summary>
    /// The alternate_contact_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AlternateContactType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("alternate_contact_type");
        set => this.WithProperty("alternate_contact_type", value);
    }

    /// <summary>
    /// The email_address attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? EmailAddress
    {
        get => GetProperty<TerraformLiteralProperty<string>>("email_address");
        set => this.WithProperty("email_address", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The phone_number attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PhoneNumber
    {
        get => GetProperty<TerraformLiteralProperty<string>>("phone_number");
        set => this.WithProperty("phone_number", value);
    }

    /// <summary>
    /// The title attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Title
    {
        get => GetProperty<TerraformLiteralProperty<string>>("title");
        set => this.WithProperty("title", value);
    }

}
