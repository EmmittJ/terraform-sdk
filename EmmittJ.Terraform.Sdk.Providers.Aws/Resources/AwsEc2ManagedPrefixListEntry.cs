using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ec2_managed_prefix_list_entry resource.
/// </summary>
public class AwsEc2ManagedPrefixListEntry : TerraformResource
{
    public AwsEc2ManagedPrefixListEntry(string name) : base("aws_ec2_managed_prefix_list_entry", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The cidr attribute.
    /// </summary>
    public string? Cidr
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cidr")?.Value;
        set => this.WithProperty("cidr", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The prefix_list_id attribute.
    /// </summary>
    public string? PrefixListId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("prefix_list_id")?.Value;
        set => this.WithProperty("prefix_list_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
