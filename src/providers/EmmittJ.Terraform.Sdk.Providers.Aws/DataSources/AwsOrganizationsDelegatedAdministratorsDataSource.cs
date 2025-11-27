using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_organizations_delegated_administrators Terraform data source.
/// Retrieves information about a aws_organizations_delegated_administrators.
/// </summary>
public partial class AwsOrganizationsDelegatedAdministratorsDataSource(string name) : TerraformDataSource("aws_organizations_delegated_administrators", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The service_principal attribute.
    /// </summary>
    public TerraformValue<string>? ServicePrincipal
    {
        get => new TerraformReference<string>(this, "service_principal");
        set => SetArgument("service_principal", value);
    }

    /// <summary>
    /// The delegated_administrators attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> DelegatedAdministrators
    {
        get => TerraformSet<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformSet<TerraformMap<object>>>(this, "delegated_administrators").ResolveNodes(ctx));
    }

}
