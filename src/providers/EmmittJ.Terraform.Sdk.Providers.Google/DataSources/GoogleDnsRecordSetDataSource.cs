using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_dns_record_set Terraform data source.
/// Retrieves information about a google_dns_record_set.
/// </summary>
public partial class GoogleDnsRecordSetDataSource(string name) : TerraformDataSource("google_dns_record_set", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The managed_zone attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagedZone is required")]
    public required TerraformValue<string> ManagedZone
    {
        get => GetArgument<TerraformValue<string>>("managed_zone");
        set => SetArgument("managed_zone", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The rrdatas attribute.
    /// </summary>
    public TerraformList<string> Rrdatas
        => AsReference("rrdatas");

    /// <summary>
    /// The ttl attribute.
    /// </summary>
    public TerraformValue<double> Ttl
        => AsReference("ttl");

}
